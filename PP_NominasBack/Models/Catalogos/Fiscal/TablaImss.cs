using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaImss.
    /// </summary>
    public class TablaImss
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("Concepto")]
        /// <summary>
        /// Obtiene o establece Concepto.
        /// </summary>
        public string? Concepto { get; set; }
        [BsonElement("PorcentajePatronal")]
        /// <summary>
        /// Obtiene o establece PorcentajePatronal.
        /// </summary>
        public decimal? PorcentajePatronal { get; set; }
        [BsonElement("PorcentajeObrero")]
        /// <summary>
        /// Obtiene o establece PorcentajeObrero.
        /// </summary>
        public decimal? PorcentajeObrero { get; set; }
        [BsonElement("SalarioMinimoAplica")]
        /// <summary>
        /// Obtiene o establece SalarioMinimoAplica.
        /// </summary>
        public bool? SalarioMinimoAplica { get; set; }
        [BsonElement("EjercicioFiscal")]
        /// <summary>
        /// Obtiene o establece EjercicioFiscal.
        /// </summary>
        int? EjercicioFiscal { get; set; }
        
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
