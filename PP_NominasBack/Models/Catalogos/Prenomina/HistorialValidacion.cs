using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase HistorialValidacion.
    /// </summary>
    public class HistorialValidacion
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("PeriodoNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; }
        [BsonElement("UsuarioValidadorId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UsuarioValidadorId.
        /// </summary>
        public string? UsuarioValidadorId { get; set; }
        [BsonElement("Resultado")]
        /// <summary>
        /// Obtiene o establece Resultado.
        /// </summary>
        public string? Resultado { get; set; }
        [BsonElement("FechaValidacion")]
        /// <summary>
        /// Obtiene o establece FechaValidacion.
        /// </summary>
        public DateTime? FechaValidacion { get; set; }
        [BsonElement("Observaciones")]
        /// <summary>
        /// Obtiene o establece Observaciones.
        /// </summary>
        public string? Observaciones { get; set; }
        
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
