using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa el DTO para el historial de horarios asignados a un empleado.
    /// </summary>
    public class HorarioEmpleadoDto
    {
        /// <summary>
        /// Identificador único del historial de horario.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Identificador del empleado relacionado.
        /// </summary>
        public string? EmpleadoId { get; set; }

        /// <summary>
        /// Identificador del turno asignado.
        /// </summary>
        public string? TurnoId { get; set; }

        /// <summary>
        /// Identificador de la plantilla de horario asignada, si aplica.
        /// </summary>
        public string? HorarioPlantillaId { get; set; }

        /// <summary>
        /// Fecha en que inicia la vigencia del horario.
        /// </summary>
        
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha en que termina la vigencia del horario (si aplica).
        /// </summary>
        public DateTime? FechaFin { get; set; }

        /// <summary>
        /// Indica si el horario está actualmente vigente.
        /// </summary>
        public bool Vigente { get; set; }

        /// <summary>
        /// Fecha de la última modificación del documento.
        /// </summary>
        [BsonElement("ultimaModificacion")]
        public DateTime? FechaUltimaModificacion { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la última modificación.
        /// </summary>
        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
