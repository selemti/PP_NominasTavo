using System;

namespace PP_Nominas.Dtos.Catalogos.Vacaciones
{
    public class VacacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? DiasProgramados { get; set; }
        public int? DiasGozados { get; set; }
        public string PeriodoVacacionalId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
