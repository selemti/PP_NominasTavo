using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia;

/// <summary>
/// Representa la clase ChecadaAgregada.
/// </summary>
public partial class ChecadaAgregada : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _id = string.Empty;
    private string _empleadoId = string.Empty;
    private DateTime _fecha;
    private string _horaEntrada = string.Empty;
    private string _horaSalida = string.Empty;
    private string _observaciones = string.Empty;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "Id")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "EmpleadoId")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Display(Name = "Fecha")]
    public DateTime Fecha
    {
        get => _fecha;
        set => SetProperty(ref _fecha, value);
    }

    [Display(Name = "Hora de entrada")]
    public string HoraEntrada
    {
        get => _horaEntrada;
        set => SetProperty(ref _horaEntrada, value);
    }

    [Display(Name = "Hora de salida")]
    public string HoraSalida
    {
        get => _horaSalida;
        set => SetProperty(ref _horaSalida, value);
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

    [Display(Name = "Usuario modificación")]
    public string UsuarioUltimaModificacion
    {
        get => _usuarioUltimaModificacion;
        set => SetProperty(ref _usuarioUltimaModificacion, value);
    }

    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        return true;
    }
}
