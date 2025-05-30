using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase TipoIncidencia.
    /// </summary>
    public class TipoIncidencia
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombreTipoIncidencia")]
        /// <summary>
        /// Obtiene o establece NombreTipoIncidencia.
        /// </summary>
        public string? NombreTipoIncidencia { get; set; }
        [BsonElement("DescripcionTipoIncidencia")]
        /// <summary>
        /// Obtiene o establece DescripcionTipoIncidencia.
        /// </summary>
        public string? DescripcionTipoIncidencia { get; set; }
        [BsonElement("RequiereJustificante")]
        /// <summary>
        /// Obtiene o establece RequiereJustificante.
        /// </summary>
        public bool? RequiereJustificante { get; set; }
        
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
