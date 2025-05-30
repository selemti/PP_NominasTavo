using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaUma.
    /// </summary>
    public class TablaUma
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("ValorUma")]
        /// <summary>
        /// Obtiene o establece ValorUma.
        /// </summary>
        public decimal? ValorUma { get; set; }
        [BsonElement("FechaInicioVigencia")]
        /// <summary>
        /// Obtiene o establece FechaInicioVigencia.
        /// </summary>
        public DateTime? FechaInicioVigencia { get; set; }
        [BsonElement("FechaFinVigencia")]
        /// <summary>
        /// Obtiene o establece FechaFinVigencia.
        /// </summary>
        public DateTime? FechaFinVigencia { get; set; }
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
