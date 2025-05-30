using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.Diagnostics;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Core;
using PP_Nominas.ViewModel;
using PP_Nominas.Helpers;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas;
using PP_Nominas.Services.Catalogos.Empleados;
using PP_Nominas.Services.Divisiones_CentrosDeCosto_Empresas;
using PP_Nominas.Converters.Catalogos.Empleados;

namespace PP_Nominas.ViewModel.Catalogos.Empleados;

/// <summary>
/// ViewModel para la vista de creación de nuevo empleado.
/// Maneja la lógica de negocio, validación y comunicación con el backend.
/// </summary>
public class NuevoEmpleadoViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    #region Servicios y Configuración

    /// <summary>Cliente HTTP para comunicación con el backend.</summary>
    private readonly HttpClient httpClient;

    /// <summary>Servicio para obtener los tipos de contrato.</summary>
    private readonly TipoContratoService _tipoContratoService = new();

    /// <summary>Servicio para obtener los Divisiones, Empresas y Centros de Costos.</summary>
    private readonly Divisiones_CentrosDeCosto_Empresas _divisionService = new();

    /// <summary>Servicio para obtener Orgranigrama.</summary>
    private readonly OrganigramaService _organigramaService = new();


    #endregion

    #region Constructor e Inicialización

    /// <summary>
    /// Inicializa una nueva instancia del ViewModel con valores predeterminados.
    /// Configura el cliente HTTP, inicializa el modelo y carga los catálogos necesarios.
    /// </summary>
    public NuevoEmpleadoViewModel()
    {
        httpClient = new HttpClient { BaseAddress = new Uri(App.BackURLBaseAddress) };

        // Configuración inicial del empleado con valores por defecto
        Empleado = new Empleado
        {
            Persona = new Persona
            {
                FechaNacimiento = DateTime.Today.AddYears(-20),
                Nacionalidad = "Mexicana"
            },
            FechaIngreso = DateTime.Today
        };

        // Carga de opciones de enumeraciones para los controles de selección
        CargarOpcionesDeEnumeraciones();

        // Comando para guardar el empleado
        GuardarCommand = new Command(async () => await GuardarAsync());

        // Carga asíncrona de catálogos externos
        _ = CargarDivisionesAsync(); // <== Carta Divisiones

        OnPropertyChanged(string.Empty);
    }

    /// <summary>
    /// Carga las opciones de enumeraciones para los controles de selección en la UI.
    /// </summary>
    private void CargarOpcionesDeEnumeraciones()
    {
        SexoOpciones = EnumHelper<SexoEnum>.ToList();
        EstadoCivilOpciones = EnumHelper<EstadoCivilEnum>.ToList();
        NivelEstudioOpciones = EnumHelper<NivelEstudioEnum>.ToList();
        TipoSangreOpciones = EnumHelper<TipoSangreEnum>.ToList();
    }

    #endregion

    #region Propiedades del Modelo Principal

    /// <summary>Modelo principal del empleado que se está creando.</summary>
    public Empleado Empleado { get; set; }


    /// <summary>Comando para ejecutar el guardado del empleado.</summary>
    public ICommand GuardarCommand { get; }

    #endregion

    #region Catálogos y Opciones

    /// <summary>Opciones de sexo disponibles para selección.</summary>
    public List<SexoEnum> SexoOpciones { get; set; }


    /// <summary>Opciones de estado civil disponibles para selección.</summary>
    public List<EstadoCivilEnum> EstadoCivilOpciones { get; set; }

    /// <summary>Opciones de nivel de estudio disponibles para selección.</summary>
    public List<NivelEstudioEnum> NivelEstudioOpciones { get; set; }

    /// <summary>Opciones de tipo de sangre disponibles para selección.</summary>
    public List<TipoSangreEnum> TipoSangreOpciones { get; set; }

    #region Enums: TipoContrato, TipoHorario, EstatusEmpleado

    public TipoContratoEnum TipoContrato
    {
        get => Empleado.TipoContrato;
        set { Empleado.TipoContrato = value; OnPropertyChanged(); }
    }

    public TipoHorarioEnum TipoHorario
    {
        get => Empleado.TipoHorario;
        set { Empleado.TipoHorario = value; OnPropertyChanged(); }
    }

    public EstatusEmpleadoEnum EstatusEmpleado
    {
        get => Empleado.EstatusEmpleado;
        set { Empleado.EstatusEmpleado = value; OnPropertyChanged(); }
    }

    public List<TipoContratoEnum> TipoContratoOpciones { get; set; } = EnumHelper<TipoContratoEnum>.ToList();
    public List<TipoHorarioEnum> TipoHorarioOpciones { get; set; } = EnumHelper<TipoHorarioEnum>.ToList();
    public List<EstatusEmpleadoEnum> EstatusEmpleadoOpciones { get; set; } = EnumHelper<EstatusEmpleadoEnum>.ToList();
    public List<TipoHorarioEnum> TurnoAsignadoOpciones { get; set; } = EnumHelper<TipoHorarioEnum>.ToList();


    #endregion



    #region División y Centro de Costo
    // División y Centro de Costo
    public List<DivisionesDTO> Divisiones { get; set; } = new();
    public DivisionesDTO? DivisionSeleccionada
    {
        get => _divisionSeleccionada;
        set
        {
            if (_divisionSeleccionada != value)
            {
                _divisionSeleccionada = value;
                OnPropertyChanged();
                _ = CargarCentrosCostoAsync();
            }
        }
    }
    private DivisionesDTO? _divisionSeleccionada;

    public List<CentroDeCostoDTO> CentrosCosto { get; set; } = new();
    private CentroDeCostoDTO? _centroSeleccionado;

    /// <summary>Centro de costo seleccionado.</summary>
    public CentroDeCostoDTO? CentroSeleccionado
    {
        get => _centroSeleccionado;
        set
        {
            if (_centroSeleccionado != value)
            {
                _centroSeleccionado = value;
                OnPropertyChanged();
                _ = CargarPlazasDesdeOrganigramaAsync();
            }
        }
    }

    private CentroDeCostoDTO? _centroCostoSeleccionado;

    // Plazas (nodos del organigrama)
    public OrganigramaNodoDTO? PlazaSeleccionada
    {
        get => _plazaSeleccionada;
        set { _plazaSeleccionada = value; OnPropertyChanged(); }
    }
    private OrganigramaNodoDTO? _plazaSeleccionada;
    /// <summary>
    /// Lista de plazas disponibles obtenidas desde el organigrama del centro de costo.
    /// </summary>
    public ObservableCollection<OrganigramaNodoDTO> PlazasDisponibles { get; set; } = new();




    #endregion
    #endregion

    #region Validación y Errores

    /// <summary>
    /// Valida el formulario completo.
    /// </summary>
    /// <returns>True si el formulario es válido, False en caso contrario.</returns>
    public bool ValidarFormulario()
    {
        var errores = ValidatorHelper.Validate(Empleado.Persona);
        return errores.Count == 0;
    }

    /// <summary>
    /// Limpia todos los mensajes de error de validación.
    /// </summary>
    public void LimpiarErrores()
    {
        ErrorNombre = ErrorApellidoPaterno = ErrorApellidoMaterno = ErrorCurp = ErrorRfc = ErrorNacionalidad = null;
        ErrorCalle = ErrorCodigoPostal = ErrorColonia = ErrorLocalidad = ErrorMunicipio = ErrorEntidadFederativa = null;
        ErrorTelefonoCelular = ErrorTelefonoCasa = null;
        ErrorSexo = ErrorEstadoCivil = ErrorNivelEstudios = ErrorTipoSangre = null;
        ErrorCorreoPersonal = null;
    }

    #region Propiedades de Error

    private string? _errorNombre;
    /// <summary>Mensaje de error para el campo Nombre.</summary>
    public string? ErrorNombre { get => _errorNombre; set { _errorNombre = value; OnPropertyChanged(); } }

    private string? _errorApellidoPaterno;
    /// <summary>Mensaje de error para el campo Apellido Paterno.</summary>
    public string? ErrorApellidoPaterno { get => _errorApellidoPaterno; set { _errorApellidoPaterno = value; OnPropertyChanged(); } }

    private string? _errorApellidoMaterno;
    /// <summary>Mensaje de error para el campo Apellido Materno.</summary>
    public string? ErrorApellidoMaterno { get => _errorApellidoMaterno; set { _errorApellidoMaterno = value; OnPropertyChanged(); } }

    private string? _errorCurp;
    /// <summary>Mensaje de error para el campo CURP.</summary>
    public string? ErrorCurp { get => _errorCurp; set { _errorCurp = value; OnPropertyChanged(); } }

    private string? _errorRfc;
    /// <summary>Mensaje de error para el campo RFC.</summary>
    public string? ErrorRfc { get => _errorRfc; set { _errorRfc = value; OnPropertyChanged(); } }

    private string? _errorNacionalidad;
    /// <summary>Mensaje de error para el campo Nacionalidad.</summary>
    public string? ErrorNacionalidad { get => _errorNacionalidad; set { _errorNacionalidad = value; OnPropertyChanged(); } }

    private string? _errorCalle;
    /// <summary>Mensaje de error para el campo Calle.</summary>
    public string? ErrorCalle { get => _errorCalle; set { _errorCalle = value; OnPropertyChanged(); } }

    private string? _errorCodigoPostal;
    /// <summary>Mensaje de error para el campo Código Postal.</summary>
    public string? ErrorCodigoPostal { get => _errorCodigoPostal; set { _errorCodigoPostal = value; OnPropertyChanged(); } }

    private string? _errorColonia;
    /// <summary>Mensaje de error para el campo Colonia.</summary>
    public string? ErrorColonia { get => _errorColonia; set { _errorColonia = value; OnPropertyChanged(); } }

    private string? _errorLocalidad;
    /// <summary>Mensaje de error para el campo Localidad.</summary>
    public string? ErrorLocalidad { get => _errorLocalidad; set { _errorLocalidad = value; OnPropertyChanged(); } }

    private string? _errorMunicipio;
    /// <summary>Mensaje de error para el campo Municipio.</summary>
    public string? ErrorMunicipio { get => _errorMunicipio; set { _errorMunicipio = value; OnPropertyChanged(); } }

    private string? _errorEntidadFederativa;
    /// <summary>Mensaje de error para el campo Entidad Federativa.</summary>
    public string? ErrorEntidadFederativa { get => _errorEntidadFederativa; set { _errorEntidadFederativa = value; OnPropertyChanged(); } }

    private string? _errorTelefonoCelular;
    /// <summary>Mensaje de error para el campo Teléfono Celular.</summary>
    public string? ErrorTelefonoCelular { get => _errorTelefonoCelular; set { _errorTelefonoCelular = value; OnPropertyChanged(); } }

    private string? _errorTelefonoCasa;
    /// <summary>Mensaje de error para el campo Teléfono de Casa.</summary>
    public string? ErrorTelefonoCasa { get => _errorTelefonoCasa; set { _errorTelefonoCasa = value; OnPropertyChanged(); } }

    private string? _errorSexo;
    /// <summary>Mensaje de error para el campo Sexo.</summary>
    public string? ErrorSexo { get => _errorSexo; set { _errorSexo = value; OnPropertyChanged(); } }

    private string? _errorEstadoCivil;
    /// <summary>Mensaje de error para el campo Estado Civil.</summary>
    public string? ErrorEstadoCivil { get => _errorEstadoCivil; set { _errorEstadoCivil = value; OnPropertyChanged(); } }

    private string? _errorNivelEstudios;
    /// <summary>Mensaje de error para el campo Nivel de Estudios.</summary>
    public string? ErrorNivelEstudios { get => _errorNivelEstudios; set { _errorNivelEstudios = value; OnPropertyChanged(); } }

    private string? _errorTipoSangre;
    /// <summary>Mensaje de error para el campo Tipo de Sangre.</summary>
    public string? ErrorTipoSangre { get => _errorTipoSangre; set { _errorTipoSangre = value; OnPropertyChanged(); } }

    private string? _errorCorreoPersonal;
    /// <summary>Mensaje de error para el campo Correo Personal.</summary>
    public string? ErrorCorreoPersonal { get => _errorCorreoPersonal; set { _errorCorreoPersonal = value; OnPropertyChanged(); } }

    #endregion

    #endregion

    #region Operaciones Principales

    /// <summary>
    /// Guarda el empleado en el backend después de validar todos los campos.
    /// Muestra alertas al usuario sobre el resultado de la operación.
    /// </summary>
    /// <returns>True si el guardado fue exitoso, False en caso contrario.</returns>
    public async Task<bool> GuardarAsync()
    {
        LimpiarErrores();
        var errores = ValidatorHelper.Validate(Empleado.Persona);

        // Asigna los mensajes de error a las propiedades correspondientes
        void SetError(string key, Action<string?> setErrorAction)
        {
            setErrorAction(errores.ContainsKey(key) ? errores[key] : null);
        }

        SetError(nameof(Empleado.Persona.Nombre), v => ErrorNombre = v);
        SetError(nameof(Empleado.Persona.ApellidoPaterno), v => ErrorApellidoPaterno = v);
        SetError(nameof(Empleado.Persona.ApellidoMaterno), v => ErrorApellidoMaterno = v);
        SetError(nameof(Empleado.Persona.Curp), v => ErrorCurp = v);
        SetError(nameof(Empleado.Persona.Rfc), v => ErrorRfc = v);
        SetError(nameof(Empleado.Persona.Nacionalidad), v => ErrorNacionalidad = v);
        SetError("Direccion.Calle", v => ErrorCalle = v);
        SetError("Direccion.CodigoPostal", v => ErrorCodigoPostal = v);
        SetError("Direccion.Colonia", v => ErrorColonia = v);
        SetError("Direccion.Localidad", v => ErrorLocalidad = v);
        SetError("Direccion.Municipio", v => ErrorMunicipio = v);
        SetError("Direccion.EntidadFederativa", v => ErrorEntidadFederativa = v);
        SetError("Telefono.Celular", v => ErrorTelefonoCelular = v);
        SetError("Telefono.Casa", v => ErrorTelefonoCasa = v);
        SetError(nameof(Empleado.Persona.Sexo), v => ErrorSexo = v);
        SetError(nameof(Empleado.Persona.EstadoCivil), v => ErrorEstadoCivil = v);
        SetError(nameof(Empleado.Persona.NivelEstudios), v => ErrorNivelEstudios = v);
        SetError(nameof(Empleado.Persona.TipoSangre), v => ErrorTipoSangre = v);
        SetError(nameof(Empleado.Persona.CorreoPersonal), v => ErrorCorreoPersonal = v);

        // Si hay errores, no continuar con el guardado
        if (errores.Any())
            return false;

        try
        {
            // Convertimos el Empleado a EmpleadoCreacionDto
            var dto = EmpleadoConverter.ToDto(Empleado); 
            var response = await httpClient.PostAsJsonAsync("api/Empleado", dto);

            if (response.IsSuccessStatusCode)
            {
                await Application.Current.MainPage.DisplayAlert("Éxito", "Empleado guardado correctamente.", "Aceptar");
                return true;
            }

            var errorMsg = await response.Content.ReadAsStringAsync();
            await Application.Current.MainPage.DisplayAlert("Error", $"Error al guardar: {errorMsg}", "Aceptar");
            return false;
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Excepción", $"Error inesperado: {ex.Message}", "Aceptar");
            return false;
        }
    }

    #endregion

    #region Propiedades Bindables

    #region Generales
    /// <summary>Nombre del empleado.</summary>
    public string Nombre { get => Empleado.Persona?.Nombre ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.Nombre = value; OnPropertyChanged(); } }

    /// <summary>Apellido paterno del empleado.</summary>
    public string ApellidoPaterno { get => Empleado.Persona?.ApellidoPaterno ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.ApellidoPaterno = value; OnPropertyChanged(); } }

    /// <summary>Apellido materno del empleado.</summary>
    public string ApellidoMaterno { get => Empleado.Persona?.ApellidoMaterno ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.ApellidoMaterno = value; OnPropertyChanged(); } }

    /// <summary>CURP del empleado.</summary>
    public string Curp { get => Empleado.Persona?.Curp ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.Curp = value; OnPropertyChanged(); } }

    /// <summary>RFC del empleado.</summary>
    public string Rfc { get => Empleado.Persona?.Rfc ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.Rfc = value; OnPropertyChanged(); } }

    /// <summary>Nacionalidad del empleado.</summary>
    public string Nacionalidad { get => Empleado.Persona?.Nacionalidad ?? string.Empty; set { if (Empleado.Persona != null) Empleado.Persona.Nacionalidad = value; OnPropertyChanged(); } }

    /// <summary>Fecha de nacimiento del empleado.</summary>
    public DateTime FechaNacimiento { get => Empleado.Persona?.FechaNacimiento ?? DateTime.Today; set { if (Empleado.Persona != null) Empleado.Persona.FechaNacimiento = value; OnPropertyChanged(); } }

    /// <summary>Fecha mínima permitida para la fecha de nacimiento (100 años atrás).</summary>
    public DateTime FechaMinimaNacimiento => DateTime.Today.AddYears(-100);

    /// <summary>Fecha máxima permitida para la fecha de nacimiento (hoy).</summary>
    public DateTime FechaMaximaNacimiento => DateTime.Today;

    /// <summary>Sexo del empleado.</summary>
    public SexoEnum Sexo { get => Empleado.Persona?.Sexo ?? SexoEnum.Masculino; set { if (Empleado.Persona != null) Empleado.Persona.Sexo = value; OnPropertyChanged(); } }

    /// <summary>Estado civil del empleado.</summary>
    public EstadoCivilEnum? EstadoCivil { get => Empleado.Persona?.EstadoCivil; set { if (Empleado.Persona != null) Empleado.Persona.EstadoCivil = value; OnPropertyChanged(); }
    }
    /// <summary>Nivel de estudios del empleado.</summary>
    public NivelEstudioEnum? NivelEstudios { get => Empleado.Persona?.NivelEstudios; set { if (Empleado.Persona != null) Empleado.Persona.NivelEstudios = value; OnPropertyChanged(); } }

    /// <summary>Tipo de sangre del empleado.</summary>
    public TipoSangreEnum? TipoSangre { get => Empleado.Persona?.TipoSangre; set { if (Empleado.Persona != null) Empleado.Persona.TipoSangre = value; OnPropertyChanged(); } }

    /// <summary>Calle de la dirección del empleado.</summary>
    public string? Calle { get => Empleado.Persona?.Direccion?.Calle; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.Calle = value; OnPropertyChanged(); } }

    /// <summary>Número exterior de la dirección del empleado.</summary>
    public string? NumeroExterior { get => Empleado.Persona?.Direccion?.NumeroExterior; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.NumeroExterior = value; OnPropertyChanged(); } }

    /// <summary>Número interior de la dirección del empleado.</summary>
    public string? NumeroInterior { get => Empleado.Persona?.Direccion?.NumeroInterior; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.NumeroInterior = value; OnPropertyChanged(); } }

    /// <summary>Código postal de la dirección del empleado.</summary>
    public string? CodigoPostal { get => Empleado.Persona?.Direccion?.CodigoPostal; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.CodigoPostal = value; OnPropertyChanged(); } }

    /// <summary>Colonia de la dirección del empleado.</summary>
    public string? Colonia { get => Empleado.Persona?.Direccion?.Colonia; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.Colonia = value; OnPropertyChanged(); } }

    /// <summary>Localidad de la dirección del empleado.</summary>
    public string? Localidad { get => Empleado.Persona?.Direccion?.Localidad; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.Localidad = value; OnPropertyChanged(); } }

    /// <summary>Municipio de la dirección del empleado.</summary>
    public string? Municipio { get => Empleado.Persona?.Direccion?.Municipio; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.Municipio = value; OnPropertyChanged(); } }

    /// <summary>Entidad federativa de la dirección del empleado.</summary>
    public string? EntidadFederativa { get => Empleado.Persona?.Direccion?.EntidadFederativa; set { if (Empleado.Persona?.Direccion != null) Empleado.Persona.Direccion.EntidadFederativa = value; OnPropertyChanged(); } }
    #endregion

    #region Teléfonos y Correo

    /// <summary>Número de teléfono celular del empleado.</summary>
    public string? TelefonoMovilNumero
    {
        get => ObtenerTelefonoPorTipo(TipoTelefono.Celular)?.Numero;
        set
        {
            var tel = ObtenerTelefonoPorTipo(TipoTelefono.Celular);
            if (tel != null) tel.Numero = value ?? string.Empty;
            else if (!string.IsNullOrWhiteSpace(value))
                Empleado.Persona.Telefonos.Add(new Telefono { Tipo = TipoTelefono.Celular, Numero = value, FechaUltimaModificacion = DateTime.Now });
            OnPropertyChanged();
        }
    }

    /// <summary>Número de teléfono de casa del empleado.</summary>
    public string? TelefonoCasaNumero
    {
        get => ObtenerTelefonoPorTipo(TipoTelefono.Casa)?.Numero;
        set
        {
            var tel = ObtenerTelefonoPorTipo(TipoTelefono.Casa);
            if (tel != null) tel.Numero = value ?? string.Empty;
            else if (!string.IsNullOrWhiteSpace(value))
                Empleado.Persona.Telefonos.Add(new Telefono { Tipo = TipoTelefono.Casa, Numero = value, FechaUltimaModificacion = DateTime.Now });
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Obtiene un teléfono específico por su tipo.
    /// </summary>
    /// <param name="tipo">Tipo de teléfono a buscar.</param>
    /// <returns>El teléfono encontrado o null si no existe.</returns>
    private Telefono? ObtenerTelefonoPorTipo(TipoTelefono tipo)
    {
        return Empleado.Persona.Telefonos.FirstOrDefault(t => t.Tipo == tipo);
    }

    /// <summary>Correo electrónico personal del empleado.</summary>
    public string CorreoPersonal
    {
        get => Empleado.Persona?.CorreoPersonal ?? string.Empty;
        set
        {
            if (Empleado.Persona != null)
            {
                Empleado.Persona.CorreoPersonal = value;
                OnPropertyChanged();
            }
        }
    }

    #endregion

    #region Laborales (desde AsignacionPlazaEmpleado)

    /// <summary>Acceso directo a la asignación principal del empleado.</summary>
    private AsignacionPlazaEmpleado Asignacion
    {
        get
        {
            if (Empleado.Asignaciones == null)
                Empleado.Asignaciones = new List<AsignacionPlazaEmpleado>();

            if (Empleado.Asignaciones.Count == 0)
                Empleado.Asignaciones.Add(new AsignacionPlazaEmpleado());

            return Empleado.Asignaciones[0];
        }
    }

    /// <summary>Jornada laboral del empleado.</summary>
    public JornadaLaboralEnum? JornadaLaboral
    {
        get => Empleado.Asignaciones.FirstOrDefault()?.JornadaLaboral;
        set
        {
            if (Empleado.Asignaciones.FirstOrDefault() is { } asignacion)
            {
                asignacion.JornadaLaboral = value ?? JornadaLaboralEnum.TiempoCompleto;
                OnPropertyChanged();
            }
        }
    }
    public List<JornadaLaboralEnum> JornadaLaboralOpciones { get; set; } = EnumHelper<JornadaLaboralEnum>.ToList();

    /// <summary>Turno asignado al empleado.</summary>
    public TipoHorarioEnum? TurnoAsignado
    {
        get => Empleado.Asignaciones.FirstOrDefault()?.TurnoAsignado;
        set
        {
            if (Empleado.Asignaciones.FirstOrDefault() is { } asignacion)
            {
                asignacion.TurnoAsignado = value ?? TipoHorarioEnum.Matutino;
                OnPropertyChanged();
            }
        }
    }

    /// <summary>¿El empleado tiene turno rotativo?</summary>
    public bool EsRotativo
    {
        get => Asignacion.EsRotativo;
        set { Asignacion.EsRotativo = value; OnPropertyChanged(); }
    }

    /// <summary>Periodicidad de pago del empleado.</summary>
    public PeriodicidadEnum PeriodicidadPago
    {
        get => Asignacion.PeriodicidadPago;
        set { Asignacion.PeriodicidadPago = value; OnPropertyChanged(); }
    }

    /// <summary>Lista de opciones de periodicidad de pago.</summary>
    public List<PeriodicidadEnum> PeriodicidadPagoOpciones { get; set; } = EnumHelper<PeriodicidadEnum>.ToList();

    /// <summary>Comentarios adicionales sobre el empleado.</summary>
    public string Comentarios
    {
        get => Asignacion.Comentarios ?? string.Empty;
        set { Asignacion.Comentarios = value; OnPropertyChanged(); }
    }

    #endregion

    #endregion

    #region Métodos de Utilidad

    /// <summary>
    /// Notifica a la vista que una propiedad ha cambiado para actualizar los bindings.
    /// </summary>
    /// <param name="name">Nombre de la propiedad que cambió (automático por CallerMemberName).</param>
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion

    #region Métodos de Carga Dinámica
    private async Task CargarDivisionesAsync()
    {
        Divisiones = await _divisionService.GetDivisionesAsync();
        OnPropertyChanged(nameof(Divisiones));
    }

    private async Task CargarCentrosCostoAsync()
    {
        CentrosCosto = DivisionSeleccionada?.CentrosDeCosto ?? new List<CentroDeCostoDTO>();
        CentroSeleccionado = null;
        OnPropertyChanged(nameof(CentrosCosto));
    }

    /// <summary>
    /// Carga las plazas (puestos) disponibles desde el organigrama asociado al centro de costo seleccionado.
    /// </summary>
    private async Task CargarPlazasDesdeOrganigramaAsync()
    {
        try
        {
            Debug.WriteLine("▶ Entrando a CargarPlazasDesdeOrganigramaAsync");

            PlazasDisponibles.Clear();
            PlazaSeleccionada = null;

            if (CentroSeleccionado?.OrganigramaId is null)
            {
                Debug.WriteLine("⚠ CentroSeleccionado no tiene OrganigramaId");
                //await MostrarAlertaAsync("Sin plazas", "Esta División no tiene plazas asignadas.");
                return;
            }

            Debug.WriteLine($"✅ Obteniendo puestos para OrganigramaId: {CentroSeleccionado.OrganigramaId}");
            var puestos = await _organigramaService.ObtenerNodosPorOrganigramaId(CentroSeleccionado.OrganigramaId);

            if (puestos == null || puestos.Count == 0)
            {
                Debug.WriteLine("⚠ No se encontraron nodos en este organigrama.");
                await UtileriasGenerales.MostrarAlertaAsync("Sin plazas", "Este centro de costos no tiene plazas disponibles.");
                //await Application.Current.MainPage.DisplayAlert(title: "Sin plazas", "Este centro de costos no tiene plazas disponibles.", "Aceptar");
                return;
            }

            puestos = puestos
                .Where(x => x.IdAsignacionPlazaEmpleado_Nominas == null)
                .OrderBy(x => x.NombrePuesto)
                .ToList();

            if (puestos.Count == 0)
            {
                Debug.WriteLine("⚠ Todos los nodos están asignados.");
                await UtileriasGenerales.MostrarAlertaAsync("Sin plazas", "Todas las plazas disponibles ya están asignadas.");
                //await Application.Current.MainPage.DisplayAlert(title: "Sin plazas", "Todas las plazas de este centro de costos ya están asignadas.", "Aceptar");
                return;
            }

            foreach (var plaza in puestos)
                PlazasDisponibles.Add(plaza);
            OnPropertyChanged(nameof(PlazasDisponibles));
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"❌ Error al cargar plazas: {ex.Message}");
            await UtileriasGenerales.MostrarAlertaAsync("Error", $"Ocurrió un error al cargar las plazas: {ex.Message}");
            //await Application.Current.MainPage.DisplayAlert(title: "Error", $"Ocurrió un error al cargar las plazas: {ex.Message}", "Aceptar");
        }
    }

    #endregion
}