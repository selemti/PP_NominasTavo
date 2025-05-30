using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase Departamento.
    /// </summary>
    public class Departamento
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("ClaveDepartamento")]
        /// <summary>
        /// Obtiene o establece ClaveDepartamento.
        /// </summary>
        public string? ClaveDepartamento { get; set; }
        [BsonElement("NombreDepartamento")]
        /// <summary>
        /// Obtiene o establece NombreDepartamento.
        /// </summary>
        public string? NombreDepartamento { get; set; }
        [BsonElement("DivisionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; }
        
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
