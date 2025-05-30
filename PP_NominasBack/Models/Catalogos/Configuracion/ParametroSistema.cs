using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase ParametroSistema.
    /// </summary>
    public class ParametroSistema
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("ClaveParametro")]
        /// <summary>
        /// Obtiene o establece ClaveParametro.
        /// </summary>
        public string? ClaveParametro { get; set; }
        [BsonElement("ValorParametro")]
        /// <summary>
        /// Obtiene o establece ValorParametro.
        /// </summary>
        public string? ValorParametro { get; set; }
        [BsonElement("DescripcionParametro")]
        /// <summary>
        /// Obtiene o establece DescripcionParametro.
        /// </summary>
        public string? DescripcionParametro { get; set; }
        
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
