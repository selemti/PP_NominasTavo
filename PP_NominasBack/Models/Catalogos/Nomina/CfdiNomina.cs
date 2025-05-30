using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase CfdiNomina.
    /// </summary>
    public class CfdiNomina
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("ReciboNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece ReciboNominaId.
        /// </summary>
        public string? ReciboNominaId { get; set; }
        [BsonElement("Uuid"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece Uuid.
        /// </summary>
        public string? Uuid { get; set; }
        [BsonElement("SelloDigital")]
        /// <summary>
        /// Obtiene o establece SelloDigital.
        /// </summary>
        public string? SelloDigital { get; set; }
        [BsonElement("FechaTimbre")]
        /// <summary>
        /// Obtiene o establece FechaTimbre.
        /// </summary>
        public DateTime? FechaTimbre { get; set; }
        
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
