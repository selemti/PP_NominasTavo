public class CuotaObreroPatronalDto
{
    public string Id { get; set; } = string.Empty;
    public string Concepto { get; set; } = string.Empty;
    public decimal? PorcentajePatron { get; set; }
    public decimal? PorcentajeEmpleado { get; set; }
    public DateTime? VigenciaInicio { get; set; }
    public DateTime? VigenciaFin { get; set; }
    public DateTime FechaUltimaModificacion { get; set; }
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
