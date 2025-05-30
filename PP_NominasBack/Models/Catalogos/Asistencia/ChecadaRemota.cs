using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase ChecadaRemota.
    /// </summary>
    public class ChecadaRemota
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

        [BsonElement("FechaHora")]
        /// <summary>
        /// Obtiene o establece FechaHora.
        /// </summary>
        public DateTime FechaHora { get; set; }

        [BsonElement("TipoEvento")]
        /// <summary>
        /// Obtiene o establece TipoEvento.
        /// </summary>
        public int TipoEvento { get; set; }

        [BsonElement("Latitud")]
        /// <summary>
        /// Obtiene o establece Latitud.
        /// </summary>
        public decimal Latitud { get; set; }

        [BsonElement("Longitud")]
        /// <summary>
        /// Obtiene o establece Longitud.
        /// </summary>
        public decimal Longitud { get; set; }

        [BsonElement("UbicacionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UbicacionId.
        /// </summary>
        public string? UbicacionId { get; set; }

        [BsonElement("FotoAdjunta")]
        /// <summary>
        /// Obtiene o establece FotoAdjunta.
        /// </summary>
        public string? FotoAdjunta { get; set; }

        
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
