using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    /// <summary>
    /// Representa la clase Perfil.
    /// </summary>
    public class Perfil
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombrePerfil")]
        /// <summary>
        /// Obtiene o establece NombrePerfil.
        /// </summary>
        public string? NombrePerfil { get; set; }
        [BsonElement("DescripcionPerfil")]
        /// <summary>
        /// Obtiene o establece DescripcionPerfil.
        /// </summary>
        public string? DescripcionPerfil { get; set; }
        
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
