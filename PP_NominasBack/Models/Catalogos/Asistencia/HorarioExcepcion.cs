using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HorarioExcepcion.
    /// </summary>
    public class HorarioExcepcion
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("FechaInicio")]
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }
        [BsonElement("FechaFin")]
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }
        [BsonElement("TurnoEspecialId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece TurnoEspecialId.
        /// </summary>
        public string? TurnoEspecialId { get; set; }
        
        /// <summary>
        /// Obtiene o establece Auditable.
        /// </summary>
        
    
    /// <summary>
    /// Fecha de la última modificación del documento.
    /// </summary>
    [BsonElement("ultimaModificacion")]
    public DateTime FechaUltimaModificacion { get; set; }

    /// <summary>
    /// Identificador del usuario que realizó la última modificación.
    /// </summary>
    [BsonElement("usuarioUltimaModificacion")]
    public string? UsuarioUltimaModificacion { get; set; }
}
}
