using System;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class PasoFlujoValidacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string FlujoValidacionId { get; set; } = string.Empty;
        public int Orden { get; set; }
        public string NombrePaso { get; set; } = string.Empty;
        public string TipoResponsable { get; set; } = string.Empty;
        public string? UsuarioId { get; set; }
        public string? PerfilId { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string? Comentarios { get; set; }
        public DateTime? FechaValidacion { get; set; }
        public string? IpValidacion { get; set; }
        public string? Dispositivo { get; set; }
    }
}
