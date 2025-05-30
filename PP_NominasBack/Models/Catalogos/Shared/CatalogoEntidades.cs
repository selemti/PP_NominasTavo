using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase CatalogoEntidades.
    /// </summary>
    public class CatalogoEntidades
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EntityCode")]
        /// <summary>
        /// Obtiene o establece EntityCode.
        /// </summary>
        public string? EntityCode { get; set; }
        [BsonElement("NombreEntidad")]
        /// <summary>
        /// Obtiene o establece NombreEntidad.
        /// </summary>
        public string? NombreEntidad { get; set; }
        [BsonElement("ModuloRelacionado")]
        /// <summary>
        /// Obtiene o establece ModuloRelacionado.
        /// </summary>
        public string? ModuloRelacionado { get; set; }
        [BsonElement("DescripcionEntidad")]
        /// <summary>
        /// Obtiene o establece DescripcionEntidad.
        /// </summary>
        public string? DescripcionEntidad { get; set; }
        
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
