using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Modelo frontend que representa la clase TipoContrato.</summary>
public partial class TipoContrato : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _id = string.Empty;
    private string _nombreContrato = string.Empty;
    private string _descripcionContrato = string.Empty;
    private string _claveSat = string.Empty;
    private bool _activo = true;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Required]
    [Display(Name = "Nombre del contrato")]
    public string NombreContrato
    {
        get => _nombreContrato;
        set => SetProperty(ref _nombreContrato, value);
    }

    [Display(Name = "Descripción")]
    public string DescripcionContrato
    {
        get => _descripcionContrato;
        set => SetProperty(ref _descripcionContrato, value);
    }

    [Display(Name = "Clave SAT")]
    public string ClaveSat
    {
        get => _claveSat;
        set => SetProperty(ref _claveSat, value);
    }

    [Display(Name = "Activo")]
    public bool Activo
    {
        get => _activo;
        set => SetProperty(ref _activo, value);
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

    protected void SetProperty<T>(ref T backingField, T value, [CallerMemberName] string? propertyName = null)
    {
        if (!Equals(backingField, value))
        {
            backingField = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
