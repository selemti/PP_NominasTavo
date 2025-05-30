using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase DetallePercepciones.
    /// </summary>
    public class DetallePercepciones
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        string Id { get; set; }

        [BsonElement("ReciboNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece ReciboNominaId.
        /// </summary>
        public string? ReciboNominaId { get; set; }
        [BsonElement("TipoCompensacionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece TipoCompensacionId.
        /// </summary>
        public string? TipoCompensacionId { get; set; }
        [BsonElement("Monto")]
        /// <summary>
        /// Obtiene o establece Monto.
        /// </summary>
        public decimal? Monto { get; set; }
        [BsonElement("TipoFiscalizacion")]
        /// <summary>
        /// Obtiene o establece TipoFiscalizacion.
        /// </summary>
        int? TipoFiscalizacion { get; set; }
        
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
