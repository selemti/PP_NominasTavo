using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class HorarioExcepcionDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string TurnoEspecialId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
