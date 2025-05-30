using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase RangoTolerancia.
    /// </summary>
    public class RangoTolerancia
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        string Id { get; set; }

        [BsonElement("Codigo")]
        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        public string? Codigo { get; set; }
        [BsonElement("Nombre")]
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }
        [BsonElement("MinutosDesde")]
        /// <summary>
        /// Obtiene o establece MinutosDesde.
        /// </summary>
        int? MinutosDesde { get; set; }
        [BsonElement("MinutosHasta")]
        /// <summary>
        /// Obtiene o establece MinutosHasta.
        /// </summary>
        int? MinutosHasta { get; set; }
        [BsonElement("Penalizacion")]
        /// <summary>
        /// Obtiene o establece Penalizacion.
        /// </summary>
        public bool? Penalizacion { get; set; }
        
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
