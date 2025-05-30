using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class HorarioEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string TurnoId { get; set; } = string.Empty;
        public string? HorarioPlantillaId { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.MinValue;
        public DateTime? FechaFin { get; set; }
        public bool Vigente { get; set; }

        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
