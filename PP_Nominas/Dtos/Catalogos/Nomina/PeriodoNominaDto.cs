using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class PeriodoNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string TipoNomina { get; set; } = string.Empty; // Enum como string (correcto en DTO)
        public string TipoPeriodoId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
