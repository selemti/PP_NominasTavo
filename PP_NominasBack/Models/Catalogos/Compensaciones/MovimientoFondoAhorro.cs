using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase MovimientoFondoAhorro.
    /// </summary>
    public class MovimientoFondoAhorro
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("FondoAhorroId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece FondoAhorroId.
        /// </summary>
        public string? FondoAhorroId { get; set; }
        [BsonElement("TipoMovimiento")]
        /// <summary>
        /// Obtiene o establece TipoMovimiento.
        /// </summary>
        int? TipoMovimiento { get; set; }
        [BsonElement("Monto")]
        /// <summary>
        /// Obtiene o establece Monto.
        /// </summary>
        public decimal? Monto { get; set; }
        [BsonElement("FechaMovimiento")]
        /// <summary>
        /// Obtiene o establece FechaMovimiento.
        /// </summary>
        public DateTime? FechaMovimiento { get; set; }
        [BsonElement("Descripcion")]
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }
        
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
