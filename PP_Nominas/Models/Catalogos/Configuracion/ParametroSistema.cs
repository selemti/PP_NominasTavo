using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Configuracion;

/// <summary>
/// Representa la clase ParametroSistema.
/// </summary>
public partial class ParametroSistema : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _claveParametro = string.Empty;
    private string _valorParametro = string.Empty;
    private string _descripcionParametro = string.Empty;
    private DateTime _fechaUltimaModificacion = DateTime.MinValue;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID del parámetro")]
    public string Id
    {
        get => _id;
        set { _id = value; OnPropertyChanged(nameof(Id)); }
    }

    [Display(Name = "Clave única del parámetro")]
    public string ClaveParametro
    {
        get => _claveParametro;
        set { _claveParametro = value; OnPropertyChanged(nameof(ClaveParametro)); }
    }

    [Display(Name = "Valor configurado")]
    public string ValorParametro
    {
        get => _valorParametro;
        set { _valorParametro = value; OnPropertyChanged(nameof(ValorParametro)); }
    }

    [Display(Name = "Descripción del parámetro")]
    public string DescripcionParametro
    {
        get => _descripcionParametro;
        set { _descripcionParametro = value; OnPropertyChanged(nameof(DescripcionParametro)); }
    }

    [Display(Name = "Fecha de última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set { _fechaUltimaModificacion = value; OnPropertyChanged(nameof(FechaUltimaModificacion)); }
    }

    [Display(Name = "Usuario de última modificación")]
    public string UsuarioUltimaModificacion
    {
        get => _usuarioUltimaModificacion;
        set { _usuarioUltimaModificacion = value; OnPropertyChanged(nameof(UsuarioUltimaModificacion)); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
