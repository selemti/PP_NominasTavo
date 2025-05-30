using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina;

/// <summary>
/// Representa la clase ConceptoFiniquito.
/// </summary>
public partial class ConceptoFiniquito : NotifyPropertyChangedBase
{
    private string _finiquitoLiquidacionId = string.Empty;
    private string _codigo = string.Empty;
    private string _descripcion = string.Empty;
    private bool _esPercepcion;
    private decimal _importe;
    private DateTime _fechaUltimaModificacion = DateTime.MinValue;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "Finiquito / Liquidación")]
    public string FiniquitoLiquidacionId
    {
        get => _finiquitoLiquidacionId;
        set => SetProperty(ref _finiquitoLiquidacionId, value);
    }

    [Display(Name = "Código")]
    public string Codigo
    {
        get => _codigo;
        set => SetProperty(ref _codigo, value);
    }

    [Display(Name = "Descripción")]
    public string Descripcion
    {
        get => _descripcion;
        set => SetProperty(ref _descripcion, value);
    }

    [Display(Name = "Es percepción")]
    public bool EsPercepcion
    {
        get => _esPercepcion;
        set => SetProperty(ref _esPercepcion, value);
    }

    [Display(Name = "Importe")]
    public decimal Importe
    {
        get => _importe;
        set => SetProperty(ref _importe, value);
    }

    [Display(Name = "Fecha de última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

    [Display(Name = "Usuario de última modificación")]
    public string UsuarioUltimaModificacion
    {
        get => _usuarioUltimaModificacion;
        set => SetProperty(ref _usuarioUltimaModificacion, value);
    }
}
