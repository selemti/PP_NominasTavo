using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase HistorialIncidencia.
    /// </summary>
    public class HistorialIncidencia
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("IncidenciaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece IncidenciaId.
        /// </summary>
        public string? IncidenciaId { get; set; }
        [BsonElement("FechaCambio")]
        /// <summary>
        /// Obtiene o establece FechaCambio.
        /// </summary>
        public DateTime? FechaCambio { get; set; }
        [BsonElement("DescripcionCambio")]
        /// <summary>
        /// Obtiene o establece DescripcionCambio.
        /// </summary>
        public string? DescripcionCambio { get; set; }
        
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
