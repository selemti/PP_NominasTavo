using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa el historial de asignación de turnos o plantillas de horario a un empleado.
    /// </summary>
    public class HorarioEmpleado
    {
        /// <summary>
        /// Identificador único del historial de horario.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// Identificador del empleado relacionado.
        /// </summary>
        [BsonElement("empleadoId"), BsonRepresentation(BsonType.ObjectId)]
  
        public string? EmpleadoId { get; set; }

        /// <summary>
        /// Identificador del turno asignado.
        /// </summary>
        [BsonElement("turnoId"), BsonRepresentation(BsonType.ObjectId)]
        public string? TurnoId { get; set; }

        /// <summary>
        /// Identificador de la plantilla de horario asignada, si aplica.
        /// </summary>
        [BsonElement("horarioPlantillaId"), BsonRepresentation(BsonType.ObjectId)]
        public string? HorarioPlantillaId { get; set; }

        /// <summary>
        /// Fecha en que inicia la vigencia del horario.
        /// </summary>
        [BsonElement("fechaInicio")]
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha en que termina la vigencia del horario (si aplica).
        /// </summary>
        [BsonElement("fechaFin")]
        public DateTime? FechaFin { get; set; }

        /// <summary>
        /// Indica si el horario está actualmente vigente.
        /// </summary>
        [BsonElement("vigente")]
        public bool Vigente { get; set; }
        public string? UsuarioUltimaModificacion { get; internal set; }
        public object PlantillaHorarioId { get; internal set; }
    }
}
