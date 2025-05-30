using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Documento genérico de historial de cambios.
    /// </summary>
    /// <summary>
    /// Representa la clase HistorialDocumento.
    /// </summary>
    public class HistorialDocumento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("entidad")]
        /// <summary>
        /// Obtiene o establece Entidad.
        /// </summary>
        public string? Entidad { get; set; }           // p.ej. "AlertaNotificacion"

        [BsonElement("entidadId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EntidadId.
        /// </summary>
        public string?  EntidadId { get; set; }       // Id del documento original

        [BsonElement("snapshot")]
        /// <summary>
        /// Obtiene o establece Snapshot.
        /// </summary>
        public BsonDocument Snapshot { get; set; }    // Copia completa antes del cambio

        [BsonElement("fechaCambio")]
        /// <summary>
        /// Obtiene o establece FechaCambio.
        /// </summary>
        public DateTime FechaCambio { get; set; }     // Cuándo se guardó el snapshot

        [BsonElement("usuarioId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UsuarioId.
        /// </summary>
        public string? UsuarioId { get; set; }         // Quién hizo el cambio
    
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