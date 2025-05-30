using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaInfonavit.
    /// </summary>
    public class TablaInfonavit
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("TipoDescuento")]
        /// <summary>
        /// Obtiene o establece TipoDescuento.
        /// </summary>
        int? TipoDescuento { get; set; }
        [BsonElement("ValorDescuento")]
        /// <summary>
        /// Obtiene o establece ValorDescuento.
        /// </summary>
        public decimal? ValorDescuento { get; set; }
        [BsonElement("Descripcion")]
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }
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
