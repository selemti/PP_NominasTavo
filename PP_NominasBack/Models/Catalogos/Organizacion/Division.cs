using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase Division.
    /// </summary>
    public class Division
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("GrupoEmpresaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece GrupoEmpresaId.
        /// </summary>
        public string? GrupoEmpresaId { get; set; }
        [BsonElement("ClaveDivision")]
        /// <summary>
        /// Obtiene o establece ClaveDivision.
        /// </summary>
        public string? ClaveDivision { get; set; }
        [BsonElement("NombreDivision")]
        /// <summary>
        /// Obtiene o establece NombreDivision.
        /// </summary>
        public string? NombreDivision { get; set; }
        
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
