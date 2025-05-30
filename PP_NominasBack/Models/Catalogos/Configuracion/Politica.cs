using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase Politica.
    /// </summary>
    public class Politica
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombrePolitica")]
        /// <summary>
        /// Obtiene o establece NombrePolitica.
        /// </summary>
        public string? NombrePolitica { get; set; }
        [BsonElement("DescripcionPolitica")]
        /// <summary>
        /// Obtiene o establece DescripcionPolitica.
        /// </summary>
        public string? DescripcionPolitica { get; set; }
        [BsonElement("VersionPolitica")]
        /// <summary>
        /// Obtiene o establece VersionPolitica.
        /// </summary>
        public string? VersionPolitica { get; set; }
        [BsonElement("FechaInicioVigencia")]
        /// <summary>
        /// Obtiene o establece FechaInicioVigencia.
        /// </summary>
        public DateTime? FechaInicioVigencia { get; set; }
        [BsonElement("FechaFinVigencia")]
        /// <summary>
        /// Obtiene o establece FechaFinVigencia.
        /// </summary>
        public string? FechaFinVigencia { get; set; }
        
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
