using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina;

/// <summary>
/// Representa la clase CfdiNomina.
/// </summary>
public partial class CfdiNomina : NotifyPropertyChangedBase
{
    private string _id = string.Empty;
    private string _reciboNominaId = string.Empty;
    private string _uuid = string.Empty;
    private string _selloDigital = string.Empty;
    private DateTime? _fechaTimbre;
    private DateTime _fechaUltimaModificacion = DateTime.MinValue;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID del CFDI")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Recibo relacionado")]
    public string ReciboNominaId
    {
        get => _reciboNominaId;
        set => SetProperty(ref _reciboNominaId, value);
    }

    [Display(Name = "UUID del comprobante SAT")]
    public string Uuid
    {
        get => _uuid;
        set => SetProperty(ref _uuid, value);
    }

    [Display(Name = "Sello digital del CFDI")]
    public string SelloDigital
    {
        get => _selloDigital;
        set => SetProperty(ref _selloDigital, value);
    }

    [Display(Name = "Fecha de timbrado SAT")]
    public DateTime? FechaTimbre
    {
        get => _fechaTimbre;
        set => SetProperty(ref _fechaTimbre, value);
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
