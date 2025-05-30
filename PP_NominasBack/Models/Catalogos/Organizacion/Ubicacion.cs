using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase Ubicacion.
    /// </summary>
    public class Ubicacion
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        string Id { get; set; }

        [BsonElement("Nombre")]
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }
        [BsonElement("Latitud")]
        /// <summary>
        /// Obtiene o establece Latitud.
        /// </summary>
        public decimal? Latitud { get; set; }
        [BsonElement("Longitud")]
        /// <summary>
        /// Obtiene o establece Longitud.
        /// </summary>
        public decimal? Longitud { get; set; }
        [BsonElement("Radio")]
        /// <summary>
        /// Obtiene o establece Radio.
        /// </summary>
        public decimal? Radio { get; set; }
        [BsonElement("TipoUbicacion")]
        /// <summary>
        /// Obtiene o establece TipoUbicacion.
        /// </summary>
        int? TipoUbicacion { get; set; }
        
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
