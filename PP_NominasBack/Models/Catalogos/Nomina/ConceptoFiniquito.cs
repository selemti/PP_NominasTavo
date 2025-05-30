// Models/Catalogos/Nomina/ConceptoFiniquito.cs
using MongoDB.Bson;
using System;
using MongoDB.Bson.Serialization.Attributes;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ConceptoFiniquito.
    /// </summary>
    public class ConceptoFiniquito
    {
        [BsonId]
        public  IReadOnlyCollection<string> Id { get; set; }

        [BsonElement("FiniquitoLiquidacionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece FiniquitoLiquidacionId.
        /// </summary>
        public string? FiniquitoLiquidacionId { get; set; }

        [BsonElement("Codigo")]
        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        public string? Codigo { get; set; }

        [BsonElement("Descripcion")]
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }

        [BsonElement("EsPercepcion")]
        /// <summary>
        /// Obtiene o establece EsPercepcion.
        /// </summary>
        public bool EsPercepcion { get; set; }

        [BsonElement("Importe")]
        /// <summary>
        /// Obtiene o establece Importe.
        /// </summary>
        public decimal Importe { get; set; }
    
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
