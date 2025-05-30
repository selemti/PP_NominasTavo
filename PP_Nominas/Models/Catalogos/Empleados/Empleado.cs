using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Models.Catalogos.Empleados;

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
    private List<RegistroImss> _registrosImss = new();
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

    public string? Id { get => _id; set => SetProperty(ref _id, value); }

    [Required, Display(Name = "Número de empleado")]
    public string NumeroEmpleado { get => _numeroEmpleado; set => SetProperty(ref _numeroEmpleado, value); }

    [Required, Display(Name = "Datos personales")]
    public Persona Persona { get => _persona; set => SetProperty(ref _persona, value); }

    [Required, Display(Name = "NSS")]
    public string Nss { get => _nss; set => SetProperty(ref _nss, value); }

    [Display(Name = "Fecha de ingreso")]
    public DateTime FechaIngreso { get => _fechaIngreso; set => SetProperty(ref _fechaIngreso, value); }

    [Display(Name = "Tipo de Contrato")]
    public TipoContratoEnum TipoContrato { get => _tipoContrato; set => SetProperty(ref _tipoContrato, value); }

    [Display(Name = "Tipo de Horario")]
    public TipoHorarioEnum TipoHorario { get => _tipoHorario; set => SetProperty(ref _tipoHorario, value); }

    [Display(Name = "Estatus del Empleado")]
    public EstatusEmpleadoEnum EstatusEmpleado { get => _estatusEmpleado; set => SetProperty(ref _estatusEmpleado, value); }

    [Display(Name = "Asignaciones")]
    public List<AsignacionPlazaEmpleado> Asignaciones { get => _asignaciones; set => SetProperty(ref _asignaciones, value); }

    [Display(Name = "Ubicaciones")]
    public List<UbicacionEmpleado> HistorialUbicaciones { get => _historialUbicaciones; set => SetProperty(ref _historialUbicaciones, value); }

    [Display(Name = "Registros IMSS")]
    public List<RegistroImss> RegistrosImss { get => _registrosImss; set => SetProperty(ref _registrosImss, value); }

    [Display(Name = "Horarios")]
    public List<HorarioEmpleado> Horarios { get => _horarios; set => SetProperty(ref _horarios, value); }

    [Display(Name = "Datos de pago")]
    public DatosPagoEmpleado DatosPago { get => _datosPago; set => SetProperty(ref _datosPago, value); }

    [Display(Name = "Documentos")]
    public List<DocumentoEmpleado> Documentos { get => _documentos; set => SetProperty(ref _documentos, value); }

    [Display(Name = "Contactos de emergencia")]
    public List<ContactoEmergencia> ContactosEmergencia { get => _contactosEmergencia; set => SetProperty(ref _contactosEmergencia, value); }

    public string CorreoCorporativo { get => _correoCorporativo; set => SetProperty(ref _correoCorporativo, value); }

    public string UsuarioRed { get => _usuarioRed; set => SetProperty(ref _usuarioRed, value); }

    public string IdBiometrico { get => _idBiometrico; set => SetProperty(ref _idBiometrico, value); }

    public string? FotoPerfilUrl { get => _fotoPerfilUrl; set => SetProperty(ref _fotoPerfilUrl, value); }

    public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

    public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(name);
        return true;
    }
}
