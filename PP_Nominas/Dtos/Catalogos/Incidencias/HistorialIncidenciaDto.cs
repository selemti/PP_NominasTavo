using System;

namespace PP_Nominas.Dtos.Catalogos.Incidencias
{
    public class HistorialIncidenciaDto
    {
        public string Id { get; set; } = string.Empty;
        public string IncidenciaId { get; set; } = string.Empty;
        public DateTime? FechaCambio { get; set; }
        public string DescripcionCambio { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
