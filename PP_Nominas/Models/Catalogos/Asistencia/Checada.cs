using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia;

/// <summary>Representa la clase Checada.</summary>
public partial class Checada : INotifyPropertyChanged
{
    public string Id { get; set; } = string.Empty;
    public string EmpleadoId { get; set; } = string.Empty;
    public DateTime FechaHora { get; set; }
    public int TipoEvento { get; set; }
    public string DispositivoId { get; set; } = string.Empty;
    public List<double>? HorasTrabajadas { get; set; }
    public DateTime FechaUltimaModificacion { get; set; }
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;

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
