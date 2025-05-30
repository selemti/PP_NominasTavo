using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase Plaza.
    /// </summary>
    public class Plaza
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("ClavePlaza")]
        /// <summary>
        /// Obtiene o establece ClavePlaza.
        /// </summary>
        public string? ClavePlaza { get; set; }
        [BsonElement("NombrePlaza")]
        /// <summary>
        /// Obtiene o establece NombrePlaza.
        /// </summary>
        public string? NombrePlaza { get; set; }
        [BsonElement("PuestoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }
        [BsonElement("DepartamentoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DepartamentoId.
        /// </summary>
        public string? DepartamentoId { get; set; }
        [BsonElement("EstatusPlaza")]
        /// <summary>
        /// Obtiene o establece EstatusPlaza.
        /// </summary>
        int? EstatusPlaza { get; set; }
        
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
