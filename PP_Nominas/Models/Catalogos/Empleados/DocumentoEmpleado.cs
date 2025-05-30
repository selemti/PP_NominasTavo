using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Documento entregado por el empleado.</summary>
public class DocumentoEmpleado : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _tipo = string.Empty;
    private string _nombreArchivo = string.Empty;
    private bool _validado;
    private string _tipoDocumento = string.Empty;
    private string _descripcion = string.Empty;
    private string _urlArchivo = string.Empty;
    private DateTime _fechaEntrega;
    private bool _esObligatorio;
    private bool _estaVigente;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Tipo")]
    public string Tipo
    {
        get => _tipo;
        set => SetProperty(ref _tipo, value);
    }

    [Display(Name = "Nombre del archivo")]
    public string NombreArchivo
    {
        get => _nombreArchivo;
        set => SetProperty(ref _nombreArchivo, value);
    }

    [Display(Name = "Validado")]
    public bool Validado
    {
        get => _validado;
        set => SetProperty(ref _validado, value);
    }

    [Required]
    [Display(Name = "Tipo de documento")]
    public string TipoDocumento
    {
        get => _tipoDocumento;
        set => SetProperty(ref _tipoDocumento, value);
    }

    [Display(Name = "Descripción")]
    public string Descripcion
    {
        get => _descripcion;
        set => SetProperty(ref _descripcion, value);
    }

    [Required]
    [Display(Name = "Archivo")]
    public string UrlArchivo
    {
        get => _urlArchivo;
        set => SetProperty(ref _urlArchivo, value);
    }

    [Display(Name = "Fecha de entrega")]
    public DateTime FechaEntrega
    {
        get => _fechaEntrega;
        set => SetProperty(ref _fechaEntrega, value);
    }

    [Display(Name = "¿Obligatorio?")]
    public bool EsObligatorio
    {
        get => _esObligatorio;
        set => SetProperty(ref _esObligatorio, value);
    }

    [Display(Name = "¿Vigente?")]
    public bool EstaVigente
    {
        get => _estaVigente;
        set => SetProperty(ref _estaVigente, value);
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
