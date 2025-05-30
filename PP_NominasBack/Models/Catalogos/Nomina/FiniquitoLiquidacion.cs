// Models/Catalogos/Nomina/FiniquitoLiquidacion.cs
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase FiniquitoLiquidacion.
    /// </summary>
    public class FiniquitoLiquidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [BsonElement("FechaFiniquito")]
        /// <summary>
        /// Obtiene o establece FechaFiniquito.
        /// </summary>
        public DateTime FechaFiniquito { get; set; }

        [BsonElement("IsrCalculado")]
        /// <summary>
        /// Obtiene o establece IsrCalculado.
        /// </summary>
        public decimal IsrCalculado { get; set; }

        [BsonElement("TotalFiniquito")]
        /// <summary>
        /// Obtiene o establece TotalFiniquito.
        /// </summary>
        public decimal TotalFiniquito { get; set; }

        [BsonElement("Conceptos")]
        /// <summary>
        /// Obtiene o establece Conceptos.
        /// </summary>
        public List<ConceptoFiniquito> Conceptos { get; set; } = new();
    
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
