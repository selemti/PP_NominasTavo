using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Asignación de una plaza laboral al empleado.</summary>
public class AsignacionPlazaEmpleado : INotifyPropertyChanged
{
    public string? Id { get; set; }

    private string _empleadoId = string.Empty;
    private string _plazaId = string.Empty;
    private decimal? _salario;
    private TipoSalarioEnum _tipoSalario;
    private DateTime? _fechaInicio;
    private DateTime? _fechaFin;
    private bool _vigente;
    private DateTime _fechaAsignacion;
    private DateTime? _fechaLiberacion;
    private bool _activa = true;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;
    private JornadaLaboralEnum? _jornadaLaboral;
    private TipoHorarioEnum? _turnoAsignado;
    private bool _esRotativo;
    private PeriodicidadEnum _periodicidadPago;
    private string? _comentarios;


    [Required]
    [Display(Name = "ID del empleado")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Required]
    [Display(Name = "ID de plaza")]
    public string PlazaId
    {
        get => _plazaId;
        set => SetProperty(ref _plazaId, value);
    }

    [Display(Name = "Salario")]
    public decimal? Salario
    {
        get => _salario;
        set => SetProperty(ref _salario, value);
    }

    [Display(Name = "Tipo de salario")]
    public TipoSalarioEnum TipoSalario
    {
        get => _tipoSalario;
        set => SetProperty(ref _tipoSalario, value);
    }

    [Display(Name = "Fecha de inicio")]
    public DateTime? FechaInicio
    {
        get => _fechaInicio;
        set => SetProperty(ref _fechaInicio, value);
    }

    [Display(Name = "Fecha de fin")]
    public DateTime? FechaFin
    {
        get => _fechaFin;
        set => SetProperty(ref _fechaFin, value);
    }

    [Display(Name = "¿Vigente?")]
    public bool Vigente
    {
        get => _vigente;
        set => SetProperty(ref _vigente, value);
    }

    [Display(Name = "Fecha de asignación")]
    public DateTime FechaAsignacion
    {
        get => _fechaAsignacion;
        set => SetProperty(ref _fechaAsignacion, value);
    }

    [Display(Name = "Fecha de liberación")]
    public DateTime? FechaLiberacion
    {
        get => _fechaLiberacion;
        set => SetProperty(ref _fechaLiberacion, value);
    }

    [Display(Name = "¿Activa?")]
    public bool Activa
    {
        get => _activa;
        set => SetProperty(ref _activa, value);
    }

    [Display(Name = "Jornada laboral")]
    public JornadaLaboralEnum? JornadaLaboral
    {
        get => _jornadaLaboral;
        set => SetProperty(ref _jornadaLaboral, value);
    }

    [Display(Name = "Turno asignado")]
    public TipoHorarioEnum? TurnoAsignado
    {
        get => _turnoAsignado;
        set => SetProperty(ref _turnoAsignado, value);
    }

    [Display(Name = "¿Es rotativo?")]
    public bool EsRotativo
    {
        get => _esRotativo;
        set => SetProperty(ref _esRotativo, value);
    }

    [Display(Name = "Periodicidad de pago")]
    public PeriodicidadEnum PeriodicidadPago
    {
        get => _periodicidadPago;
        set => SetProperty(ref _periodicidadPago, value);
    }

    [Display(Name = "Comentarios")]
    public string? Comentarios
    {
        get => _comentarios;
        set => SetProperty(ref _comentarios, value);
    }


    [Display(Name = "Última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

    [Display(Name = "Modificado por")]
    public string UsuarioUltimaModificacion
    {
        get => _usuarioUltimaModificacion;
        set => SetProperty(ref _usuarioUltimaModificacion, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(name);
        return true;
    }
}
