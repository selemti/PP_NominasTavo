using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase Organigrama.
    /// </summary>
    public class Organigrama
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("DivisionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; }
        [BsonElement("PuestoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }
        [BsonElement("CentroCostoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece CentroCostoId.
        /// </summary>
        public string? CentroCostoId { get; set; }
        [BsonElement("NodoPadreId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece NodoPadreId.
        /// </summary>
        public string? NodoPadreId { get; set; }
        [BsonElement("Nivel")]
        /// <summary>
        /// Obtiene o establece Nivel.
        /// </summary>
        int? Nivel { get; set; }
        
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
