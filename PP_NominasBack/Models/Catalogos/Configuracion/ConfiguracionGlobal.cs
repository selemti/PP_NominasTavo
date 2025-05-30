using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase ConfiguracionGlobal.
    /// </summary>
    public class ConfiguracionGlobal
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("CategoriaConfiguracion")]
        /// <summary>
        /// Obtiene o establece CategoriaConfiguracion.
        /// </summary>
        public string? CategoriaConfiguracion { get; set; }
        [BsonElement("ClaveConfiguracion")]
        /// <summary>
        /// Obtiene o establece ClaveConfiguracion.
        /// </summary>
        public string? ClaveConfiguracion { get; set; }
        [BsonElement("ValorConfiguracion")]
        /// <summary>
        /// Obtiene o establece ValorConfiguracion.
        /// </summary>
        public string? ValorConfiguracion { get; set; }
        [BsonElement("DescripcionConfiguracion")]
        /// <summary>
        /// Obtiene o establece DescripcionConfiguracion.
        /// </summary>
        public string? DescripcionConfiguracion { get; set; }
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
