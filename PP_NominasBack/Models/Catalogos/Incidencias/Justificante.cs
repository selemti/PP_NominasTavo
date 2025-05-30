using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase Justificante.
    /// </summary>
    public class Justificante
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("TipoJustificante")]
        /// <summary>
        /// Obtiene o establece TipoJustificante.
        /// </summary>
        int? TipoJustificante { get; set; }
        [BsonElement("UrlDocumento")]
        /// <summary>
        /// Obtiene o establece UrlDocumento.
        /// </summary>
        public string? UrlDocumento { get; set; }
        [BsonElement("FechaEmision")]
        /// <summary>
        /// Obtiene o establece FechaEmision.
        /// </summary>
        public DateTime? FechaEmision { get; set; }
        
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
