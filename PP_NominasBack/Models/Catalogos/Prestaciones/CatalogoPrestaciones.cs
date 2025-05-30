using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Prestaciones
{
    /// <summary>
    /// Representa la clase CatalogoPrestaciones.
    /// </summary>
    public class CatalogoPrestaciones
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombrePrestacion")]
        /// <summary>
        /// Obtiene o establece NombrePrestacion.
        /// </summary>
        public string? NombrePrestacion { get; set; }
        [BsonElement("DescripcionPrestacion")]
        /// <summary>
        /// Obtiene o establece DescripcionPrestacion.
        /// </summary>
        public string? DescripcionPrestacion { get; set; }
        [BsonElement("AplicaEmpresaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece AplicaEmpresaId.
        /// </summary>
        public string? AplicaEmpresaId { get; set; }
        [BsonElement("AplicaDivisionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece AplicaDivisionId.
        /// </summary>
        public string? AplicaDivisionId { get; set; }
        
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
