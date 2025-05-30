using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase ControlCierrePrenomina.
    /// </summary>
    public class ControlCierrePrenomina
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
        [BsonElement("FechaCierre")]
        /// <summary>
        /// Obtiene o establece FechaCierre.
        /// </summary>
        public DateTime? FechaCierre { get; set; }
        [BsonElement("UsuarioCierreId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UsuarioCierreId.
        /// </summary>
        public string? UsuarioCierreId { get; set; }
        
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
