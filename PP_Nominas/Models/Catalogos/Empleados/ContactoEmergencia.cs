using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Persona a contactar en caso de emergencia.</summary>
public class ContactoEmergencia : INotifyPropertyChanged
{
    private string _nombre = string.Empty;
    private string _parentesco = string.Empty;
    private string _telefono = string.Empty;
    private bool _principal;
    private string? _correo;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    /// <summary>Nombre completo del contacto.</summary>
    [Required]
    [Display(Name = "Nombre del contacto")]
    public string Nombre
    {
        get => _nombre;
        set => SetProperty(ref _nombre, value);
    }

    /// <summary>Parentesco con el empleado.</summary>
    [Required]
    [Display(Name = "Parentesco")]
    public string Parentesco
    {
        get => _parentesco;
        set => SetProperty(ref _parentesco, value);
    }

    /// <summary>Teléfono de contacto.</summary>
    [Required]
    [Phone]
    [Display(Name = "Teléfono")]
    public string Telefono
    {
        get => _telefono;
        set => SetProperty(ref _telefono, value);
    }

    /// <summary>Indica si es contacto principal.</summary>
    [Display(Name = "¿Es el principal?")]
    public bool Principal
    {
        get => _principal;
        set => SetProperty(ref _principal, value);
    }

    /// <summary>Correo electrónico (opcional).</summary>
    [EmailAddress]
    [Display(Name = "Correo electrónico")]
    public string? Correo
    {
        get => _correo;
        set => SetProperty(ref _correo, value);
    }

    /// <summary>Fecha de la última modificación.</summary>
    [Display(Name = "Última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

    /// <summary>Usuario que realizó la última modificación.</summary>
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
