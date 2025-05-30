using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaIsr.
    /// </summary>
    public class TablaIsr
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("LimiteInferior")]
        /// <summary>
        /// Obtiene o establece LimiteInferior.
        /// </summary>
        public decimal? LimiteInferior { get; set; }
        [BsonElement("LimiteSuperior")]
        /// <summary>
        /// Obtiene o establece LimiteSuperior.
        /// </summary>
        public decimal? LimiteSuperior { get; set; }
        [BsonElement("CuotaFija")]
        /// <summary>
        /// Obtiene o establece CuotaFija.
        /// </summary>
        public decimal? CuotaFija { get; set; }
        [BsonElement("PorcentajeExcedente")]
        /// <summary>
        /// Obtiene o establece PorcentajeExcedente.
        /// </summary>
        public decimal? PorcentajeExcedente { get; set; }
        [BsonElement("Periodo")]
        /// <summary>
        /// Obtiene o establece Periodo.
        /// </summary>
        int? Periodo { get; set; }
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
