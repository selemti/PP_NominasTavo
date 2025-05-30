using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase TabuladorSalarial.
    /// </summary>
    public class TabuladorSalarial
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        string Id { get; set; }

        [BsonElement("PuestoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }
        [BsonElement("SalarioMinimo")]
        /// <summary>
        /// Obtiene o establece SalarioMinimo.
        /// </summary>
        public decimal? SalarioMinimo { get; set; }
        [BsonElement("SalarioMaximo")]
        /// <summary>
        /// Obtiene o establece SalarioMaximo.
        /// </summary>
        public decimal? SalarioMaximo { get; set; }
        
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
