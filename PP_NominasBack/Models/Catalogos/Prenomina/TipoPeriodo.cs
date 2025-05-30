using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase TipoPeriodo.
    /// </summary>
    public class TipoPeriodo
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombreTipoPeriodo")]
        /// <summary>
        /// Obtiene o establece NombreTipoPeriodo.
        /// </summary>
        public string? NombreTipoPeriodo { get; set; }
        [BsonElement("DiasPeriodo")]
        /// <summary>
        /// Obtiene o establece DiasPeriodo.
        /// </summary>
        int? DiasPeriodo { get; set; }
        
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
