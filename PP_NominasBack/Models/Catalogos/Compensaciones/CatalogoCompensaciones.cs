using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase CatalogoCompensaciones.
    /// </summary>
    public class CatalogoCompensaciones
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("TipoCompensacion")]
        /// <summary>
        /// Obtiene o establece TipoCompensacion.
        /// </summary>
        int? TipoCompensacion { get; set; }
        [BsonElement("NombreCompensacion")]
        /// <summary>
        /// Obtiene o establece NombreCompensacion.
        /// </summary>
        public string? NombreCompensacion { get; set; }
        [BsonElement("DescripcionCompensacion")]
        /// <summary>
        /// Obtiene o establece DescripcionCompensacion.
        /// </summary>
        public string? DescripcionCompensacion { get; set; }
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
