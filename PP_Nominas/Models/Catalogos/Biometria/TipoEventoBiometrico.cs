using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public partial class TipoEventoBiometrico : INotifyPropertyChanged
{
    private string _id = string.Empty;
    private string _nombreEvento = string.Empty;
    private string _descripcionEvento = string.Empty;
    private bool _activo;
    private DateTime _fechaUltimaModificacion = DateTime.MinValue;
    private string _usuarioUltimaModificacion = string.Empty;

    [Display(Name = "ID del tipo de evento")]
    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    [Display(Name = "Nombre del evento (entrada, salida, comida, etc.)")]
    public string NombreEvento
    {
        get => _nombreEvento;
        set => SetProperty(ref _nombreEvento, value);
    }

    [Display(Name = "Descripción detallada del evento")]
    public string DescripcionEvento
    {
        get => _descripcionEvento;
        set => SetProperty(ref _descripcionEvento, value);
    }

    [Display(Name = "Estatus activo del tipo de evento")]
    public bool Activo
    {
        get => _activo;
        set => SetProperty(ref _activo, value);
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

    protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string? propertyName = null)
    {
        if (Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
