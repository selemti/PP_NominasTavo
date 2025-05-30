using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Configuracion;

/// <summary>
/// Representa la clase Politica.
/// </summary>
public partial class Politica : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _nombrePolitica = string.Empty;
    private string _descripcionPolitica = string.Empty;
    private string _versionPolitica = string.Empty;
    private DateTime? _fechaInicioVigencia;
    private string _fechaFinVigencia = string.Empty;
    private DateTime _fechaUltimaModificacion = DateTime.MinValue;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID de la política")]
    public string Id
    {
        get => _id;
        set { _id = value; OnPropertyChanged(nameof(Id)); }
    }

    [Display(Name = "Nombre de la política")]
    public string NombrePolitica
    {
        get => _nombrePolitica;
        set { _nombrePolitica = value; OnPropertyChanged(nameof(NombrePolitica)); }
    }

    [Display(Name = "Descripción de la política")]
    public string DescripcionPolitica
    {
        get => _descripcionPolitica;
        set { _descripcionPolitica = value; OnPropertyChanged(nameof(DescripcionPolitica)); }
    }

    [Display(Name = "Número de versión")]
    public string VersionPolitica
    {
        get => _versionPolitica;
        set { _versionPolitica = value; OnPropertyChanged(nameof(VersionPolitica)); }
    }

    [Display(Name = "Fecha de inicio de vigencia")]
    public DateTime? FechaInicioVigencia
    {
        get => _fechaInicioVigencia;
        set { _fechaInicioVigencia = value; OnPropertyChanged(nameof(FechaInicioVigencia)); }
    }

    [Display(Name = "Fecha de fin de vigencia (opcional)")]
    public string FechaFinVigencia
    {
        get => _fechaFinVigencia;
        set { _fechaFinVigencia = value; OnPropertyChanged(nameof(FechaFinVigencia)); }
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
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
