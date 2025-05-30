using System;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class HistorialDocumentoDto
    {
        public string Id { get; set; } = string.Empty;
        public string Entidad { get; set; } = string.Empty;
        public string EntidadId { get; set; } = string.Empty;
        public string Snapshot { get; set; } = string.Empty;
        public DateTime FechaCambio { get; set; }
        public string UsuarioId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
