using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase LogsSincronizacion.
    /// </summary>
    public class LogsSincronizacion
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("DispositivoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DispositivoId.
        /// </summary>
        public string? DispositivoId { get; set; }
        [BsonElement("FechaEvento")]
        /// <summary>
        /// Obtiene o establece FechaEvento.
        /// </summary>
        public DateTime? FechaEvento { get; set; }
        [BsonElement("DescripcionLog")]
        /// <summary>
        /// Obtiene o establece DescripcionLog.
        /// </summary>
        public string? DescripcionLog { get; set; }
        
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
