using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Deducciones
{
    /// <summary>
    /// Representa la clase CatalogoDeducciones.
    /// </summary>
    public class CatalogoDeducciones
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("TipoDeduccion")]
        /// <summary>
        /// Obtiene o establece TipoDeduccion.
        /// </summary>
        int? TipoDeduccion { get; set; }
        [BsonElement("NombreDeduccion")]
        /// <summary>
        /// Obtiene o establece NombreDeduccion.
        /// </summary>
        public string? NombreDeduccion { get; set; }
        [BsonElement("DescripcionDeduccion")]
        /// <summary>
        /// Obtiene o establece DescripcionDeduccion.
        /// </summary>
        public string? DescripcionDeduccion { get; set; }
        [BsonElement("AplicaEmpresaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece AplicaEmpresaId.
        /// </summary>
        public string? AplicaEmpresaId { get; set; }
        
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
