using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Historial de ubicaciones donde ha laborado el empleado.</summary>
public class HistorialUbicacionEmpleado : INotifyPropertyChanged
{
    public string? Id { get; set; }

    private string _empleadoId = string.Empty;
    private string _ubicacionId = string.Empty;
    private DateTime _fechaInicio;
    private DateTime? _fechaFin;
    private string _observaciones = string.Empty;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Required]
    [Display(Name = "ID del empleado")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Required]
    [Display(Name = "ID de ubicación")]
    public string UbicacionId
    {
        get => _ubicacionId;
        set => SetProperty(ref _ubicacionId, value);
    }

    [Display(Name = "Fecha de inicio")]
    public DateTime FechaInicio
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

    [Display(Name = "Observaciones")]
    public string Observaciones
    {
        get => _observaciones;
        set => SetProperty(ref _observaciones, value);
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
