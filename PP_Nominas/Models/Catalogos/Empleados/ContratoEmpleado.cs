using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados;

/// <summary>Representa la clase ContratoEmpleado.</summary>
public class ContratoEmpleado : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _empleadoId = string.Empty;
    private int? _tipoContrato;
    private DateTime? _fechaInicioContrato;
    private DateTime? _fechaFinContrato;
    private bool? _vigente;
    private DateTime _fechaUltimaModificacion;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID del contrato laboral")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Empleado relacionado")]
    public string EmpleadoId
    {
        get => _empleadoId;
        set => SetProperty(ref _empleadoId, value);
    }

    [Display(Name = "Tipo de contrato (0 = Indeterminado, 1 = Temporal, etc.)")]
    public int? TipoContrato
    {
        get => _tipoContrato;
        set => SetProperty(ref _tipoContrato, value);
    }

    [Display(Name = "Inicio de vigencia")]
    public DateTime? FechaInicioContrato
    {
        get => _fechaInicioContrato;
        set => SetProperty(ref _fechaInicioContrato, value);
    }

    [Display(Name = "Fin de vigencia (nullable)")]
    public DateTime? FechaFinContrato
    {
        get => _fechaFinContrato;
        set => SetProperty(ref _fechaFinContrato, value);
    }

    [Display(Name = "Indica si es el contrato activo")]
    public bool? Vigente
    {
        get => _vigente;
        set => SetProperty(ref _vigente, value);
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
