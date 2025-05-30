using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Información bancaria y fiscal del empleado.</summary>
public class DatosPagoEmpleado : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _empleadoId = string.Empty;
    private string _bancoId = string.Empty;
    private string _cuentaBancaria = string.Empty;
    private int? _formaPago;
    private bool? _vigente;
    private DateTime? _fechaInicio;
    private DateTime? _fechaFin;

    private string _banco = string.Empty;
    private string _clabe = string.Empty;
    private string _numeroCuenta = string.Empty;
    private string _usoCfdi = string.Empty;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Empleado")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Display(Name = "Banco Id")]
    public string BancoId
    {
        get => _bancoId;
        set => SetProperty(ref _bancoId, value);
    }

    [Display(Name = "Cuenta bancaria")]
    public string CuentaBancaria
    {
        get => _cuentaBancaria;
        set => SetProperty(ref _cuentaBancaria, value);
    }

    [Display(Name = "Forma de pago")]
    public int? FormaPago
    {
        get => _formaPago;
        set => SetProperty(ref _formaPago, value);
    }

    [Display(Name = "Vigente")]
    public bool? Vigente
    {
        get => _vigente;
        set => SetProperty(ref _vigente, value);
    }

    [Display(Name = "Fecha inicio")]
    public DateTime? FechaInicio
    {
        get => _fechaInicio;
        set => SetProperty(ref _fechaInicio, value);
    }

    [Display(Name = "Fecha fin")]
    public DateTime? FechaFin
    {
        get => _fechaFin;
        set => SetProperty(ref _fechaFin, value);
    }

    [Display(Name = "Banco")]
    public string Banco
    {
        get => _banco;
        set => SetProperty(ref _banco, value);
    }

    [Display(Name = "CLABE")]
    public string Clabe
    {
        get => _clabe;
        set => SetProperty(ref _clabe, value);
    }

    [Display(Name = "Número de cuenta")]
    public string NumeroCuenta
    {
        get => _numeroCuenta;
        set => SetProperty(ref _numeroCuenta, value);
    }

    [Display(Name = "Uso CFDI")]
    public string UsoCfdi
    {
        get => _usoCfdi;
        set => SetProperty(ref _usoCfdi, value);
    }

    [Display(Name = "Última modificación")]
    public DateTime FechaUltimaModificacion
    {
        get => _fechaUltimaModificacion;
        set => SetProperty(ref _fechaUltimaModificacion, value);
    }

    [Display(Name = "Usuario modificador")]
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
