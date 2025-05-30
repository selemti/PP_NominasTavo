public class TipoEventoBiometricoDto
{
    public string Id { get; set; } = string.Empty;
    public string NombreEvento { get; set; } = string.Empty;
    public string DescripcionEvento { get; set; } = string.Empty;
    public bool Activo { get; set; }
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
