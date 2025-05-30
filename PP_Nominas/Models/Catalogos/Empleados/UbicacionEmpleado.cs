using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Ubicación física donde ha laborado el empleado.</summary>
public class UbicacionEmpleado : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _nombre = string.Empty;
    private string? _descripcion;
    private bool _activa = true;
    private DateTime _fechaAsignacion;
    private string _sucursalId = string.Empty;
    private string _nombreSucursal = string.Empty;
    private DateTime _fechaInicio;
    private DateTime? _fechaFin;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Nombre")]
    public string Nombre
    {
        get => _nombre;
        set => SetProperty(ref _nombre, value);
    }

    [Display(Name = "Descripción")]
    public string? Descripcion
    {
        get => _descripcion;
        set => SetProperty(ref _descripcion, value);
    }

    [Display(Name = "¿Activa?")]
    public bool Activa
    {
        get => _activa;
        set => SetProperty(ref _activa, value);
    }

    [Display(Name = "Fecha de asignación")]
    public DateTime FechaAsignacion
    {
        get => _fechaAsignacion;
        set => SetProperty(ref _fechaAsignacion, value);
    }

    [Required]
    [Display(Name = "ID de sucursal")]
    public string SucursalId
    {
        get => _sucursalId;
        set => SetProperty(ref _sucursalId, value);
    }

    [Display(Name = "Nombre de sucursal")]
    public string NombreSucursal
    {
        get => _nombreSucursal;
        set => SetProperty(ref _nombreSucursal, value);
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
