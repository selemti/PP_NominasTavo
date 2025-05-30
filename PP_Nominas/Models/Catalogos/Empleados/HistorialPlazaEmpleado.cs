using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>
/// Representa la clase HistorialPlazaEmpleado.
/// </summary>
public partial class HistorialPlazaEmpleado : INotifyPropertyChanged
{
    private string? _id;
    private string _empleadoId = string.Empty;
    private string _plazaIdAnterior = string.Empty;
    private string _plazaIdNueva = string.Empty;
    private DateTime? _fechaCambio;
    private string _motivoCambio = string.Empty;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID único del cambio de plaza")]
    public string? Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Empleado involucrado")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Display(Name = "Plaza anterior del empleado")]
    public string PlazaIdAnterior
    {
        get => _plazaIdAnterior;
        set => SetProperty(ref _plazaIdAnterior, value);
    }

    [Display(Name = "Nueva plaza asignada al empleado")]
    public string PlazaIdNueva
    {
        get => _plazaIdNueva;
        set => SetProperty(ref _plazaIdNueva, value);
    }

    [Display(Name = "Fecha del cambio de plaza")]
    public DateTime? FechaCambio
    {
        get => _fechaCambio;
        set => SetProperty(ref _fechaCambio, value);
    }

    [Display(Name = "Motivo del cambio de plaza")]
    public string MotivoCambio
    {
        get => _motivoCambio;
        set => SetProperty(ref _motivoCambio, value);
    }

    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

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
