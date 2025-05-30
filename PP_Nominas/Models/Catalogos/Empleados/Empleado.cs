using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Empleado registrado en el sistema.</summary>
public class Empleado : INotifyPropertyChanged
{
    private string? _id;
    private string _numeroEmpleado = string.Empty;
    private Persona _persona = new();
    private string _nss = string.Empty;
    private DateTime _fechaIngreso;
    private TipoContratoEnum _tipoContrato;
    private TipoHorarioEnum _tipoHorario;
    private EstatusEmpleadoEnum _estatusEmpleado;
    private List<AsignacionPlazaEmpleado> _asignaciones = new();
    private List<UbicacionEmpleado> _historialUbicaciones = new();
    private List<RegistroImss> _RegistrosImss = new();
    private List<HorarioEmpleado> _horarios = new();
    private DatosPagoEmpleado _datosPago = new();
    private List<DocumentoEmpleado> _documentos = new();
    private List<ContactoEmergencia> _contactosEmergencia = new();
    private string _correoCorporativo = string.Empty;
    private string _usuarioRed = string.Empty;
    private string _idBiometrico = string.Empty;
    private string? _fotoPerfilUrl;
private string _usuarioUltimaModificacion = string.Empty;
    private DateTime _fechaUltimaModificacion;


    /// <summary>ID único del empleado.</summary>
    [Display(Name = "ID")]
    public string? Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    /// <summary>Número de empleado.</summary>
    [Required]
    [Display(Name = "Número de empleado")]
    public string NumeroEmpleado
    {
        get => _numeroEmpleado;
        set => SetProperty(ref _numeroEmpleado, value);
    }

    /// <summary>Datos personales del empleado.</summary>
    [Required]
    [Display(Name = "Datos personales")]
    public Persona Persona
    {
        get => _persona;
        set => SetProperty(ref _persona, value);
    }

    /// <summary>Número de seguro social.</summary>
    [Required(ErrorMessage = "El NSS es obligatorio.")]

    [Display(Name = "NSS")]
    public string Nss
    {
        get => _nss;
        set => SetProperty(ref _nss, value);
    }

    /// <summary>Fecha de ingreso.</summary>
    [Display(Name = "Fecha de ingreso")]
    public DateTime FechaIngreso
    {
        get => _fechaIngreso;
        set => SetProperty(ref _fechaIngreso, value);
    }

    [Display(Name = "Tipo de Contrato")]
    public TipoContratoEnum TipoContrato
    {
        get => _tipoContrato;
        set => SetProperty(ref _tipoContrato, value);
    }

    [Display(Name = "Tipo de Horario")]
    public TipoHorarioEnum TipoHorario
    {
        get => _tipoHorario;
        set => SetProperty(ref _tipoHorario, value);
    }

    [Display(Name = "Estatus del Empleado")]
    public EstatusEmpleadoEnum EstatusEmpleado
    {
        get => _estatusEmpleado;
        set => SetProperty(ref _estatusEmpleado, value);
    }

    /// <summary>Asignaciones del empleado.</summary>
    [Display(Name = "Asignaciones")]
    public List<AsignacionPlazaEmpleado> Asignaciones
    {
        get => _asignaciones;
        set => SetProperty(ref _asignaciones, value);
    }

    /// <summary>Ubicaciones anteriores del empleado.</summary>
    [Display(Name = "Ubicaciones del empleado")]
    public List<UbicacionEmpleado> HistorialUbicaciones
    {
        get => _historialUbicaciones;
        set => SetProperty(ref _historialUbicaciones, value);
    }

    /// <summary>Registros en el IMSS.</summary>
    [Display(Name = "Registros IMSS")]
    public List<RegistroImss> RegistrosImss
    {
        get => _RegistrosImss;
        set => SetProperty(ref _RegistrosImss, value);
    }

    /// <summary>Horarios laborales asignados.</summary>
    [Display(Name = "Horarios asignados")]
    public List<HorarioEmpleado> Horarios
    {
        get => _horarios;
        set => SetProperty(ref _horarios, value);
    }

    /// <summary>Datos bancarios y forma de pago.</summary>
    [Display(Name = "Datos de pago")]
    public DatosPagoEmpleado DatosPago
    {
        get => _datosPago;
        set => SetProperty(ref _datosPago, value);
    }

    /// <summary>Documentos entregados.</summary>
    [Display(Name = "Documentos")]
    public List<DocumentoEmpleado> Documentos
    {
        get => _documentos;
        set => SetProperty(ref _documentos, value);
    }

    /// <summary>Contactos de emergencia.</summary>
    [Display(Name = "Contactos de emergencia")]
    public List<ContactoEmergencia> ContactosEmergencia
    {
        get => _contactosEmergencia;
        set => SetProperty(ref _contactosEmergencia, value);
    }

    /// <summary>Correo corporativo.</summary>
    [Display(Name = "Correo corporativo")]
    public string CorreoCorporativo
    {
        get => _correoCorporativo;
        set => SetProperty(ref _correoCorporativo, value);
    }

    /// <summary>Usuario de red.</summary>
    [Display(Name = "Usuario de red")]
    public string UsuarioRed
    {
        get => _usuarioRed;
        set => SetProperty(ref _usuarioRed, value);
    }

    /// <summary>ID biométrico.</summary>
    [Display(Name = "ID biométrico")]
    public string IdBiometrico
    {
        get => _idBiometrico;
        set => SetProperty(ref _idBiometrico, value);
    }

    /// <summary>Foto de perfil.</summary>
    [Display(Name = "Foto de perfil")]
    public string? FotoPerfilUrl
    {
        get => _fotoPerfilUrl;
        set => SetProperty(ref _fotoPerfilUrl, value);
    }

    /// <summary>Fecha de última modificación.</summary>
    [Display(Name = "Última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

    /// <summary>Modificado por.</summary>
    [Display(Name = "Modificado por")]
    public string UsuarioUltimaModificacion
    {
        get => _usuarioUltimaModificacion;
        set => SetProperty(ref _usuarioUltimaModificacion, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(name);
        return true;
    }
}
