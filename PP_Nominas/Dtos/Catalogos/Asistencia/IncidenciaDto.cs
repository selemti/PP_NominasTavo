using System;

namespace PP_Nominas.Dtos.Catalogos.Asistencia
{
    public class IncidenciaDto
    {
        public int? TipoFalta { get; set; } // Tipo de incidencia (Falta, Retardo, Permiso)
        public string ChecadaId { get; set; } = string.Empty; // Relación con la checada
        public string EstatusIncidencia { get; set; } = string.Empty; // Estado de la incidencia
        public double? DuracionRetardo { get; set; } // Duración del retardo
        public string Justificacion { get; set; } = string.Empty; // Justificación de la incidencia
        public string TipoPermiso { get; set; } = string.Empty; // Tipo de permiso (enfermedad, vacaciones, etc.)
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
