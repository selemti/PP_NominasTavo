using System;

namespace PP_Nominas.Dtos.Catalogos.Incidencias
{
    public class JustificanteDto
    {
        public string Id { get; set; } = string.Empty;
        public int? TipoJustificante { get; set; }
        public string UrlDocumento { get; set; } = string.Empty;
        public DateTime? FechaEmision { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
