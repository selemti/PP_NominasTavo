
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase CalendarioLaboral.
    /// </summary>
    public class CalendarioLaboral
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("Fecha")]
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime? Fecha { get; set; } // Fecha de evento (día laboral, festivo, etc.)

        [BsonElement("TipoDia")]
        /// <summary>
        /// Obtiene o establece TipoDia.
        /// </summary>
        int? TipoDia { get; set; } // Tipo de día (laboral, feriado, etc.)

        [BsonElement("DescripcionEvento")]
        /// <summary>
        /// Obtiene o establece DescripcionEvento.
        /// </summary>
        public string? DescripcionEvento { get; set; } // Descripción del evento (vacaciones, feriado, etc.)

        [BsonElement("EmpresaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpresaId.
        /// </summary>
        public string? EmpresaId { get; set; } // Relación con empresa

        [BsonElement("DivisionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; } // Relación con división

        [BsonElement("Vigente")]
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; } // Indica si el evento está vigente

        
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
