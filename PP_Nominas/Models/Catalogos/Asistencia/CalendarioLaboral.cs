using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia;

/// <summary>Representa la clase CalendarioLaboral.</summary>
public partial class CalendarioLaboral : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private DateTime _fecha;
    private int _tipoDia;
    private string _descripcionEvento = string.Empty;
    private string _empresaId = string.Empty;
    private string _divisionId = string.Empty;
    private bool? _vigente;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID del evento en calendario")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Fecha del evento")]
    public DateTime Fecha
    {
        get => _fecha;
        set => SetProperty(ref _fecha, value);
    }

    [Display(Name = "(0 = Laboral normal, 1 = Feriado oficial, 2 = Descanso especial)")]
    public int TipoDia
    {
        get => _tipoDia;
        set => SetProperty(ref _tipoDia, value);
    }

    [Display(Name = "Descripción breve del evento")]
    public string DescripcionEvento
    {
        get => _descripcionEvento;
        set => SetProperty(ref _descripcionEvento, value);
    }

    [Display(Name = "Empresa relacionada (opcional)")]
    public string EmpresaId
    {
        get => _empresaId;
        set => SetProperty(ref _empresaId, value);
    }

    [Display(Name = "División relacionada (opcional)")]
    public string DivisionId
    {
        get => _divisionId;
        set => SetProperty(ref _divisionId, value);
    }

    [Display(Name = "Vigente")]
    public bool? Vigente
    {
        get => _vigente;
        set => SetProperty(ref _vigente, value);
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
