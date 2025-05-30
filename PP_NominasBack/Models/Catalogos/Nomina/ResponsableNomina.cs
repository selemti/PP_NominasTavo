using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ResponsableNomina.
    /// </summary>
    public class ResponsableNomina
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("UsuarioId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UsuarioId.
        /// </summary>
        public string? UsuarioId { get; set; }
        [BsonElement("TipoResponsabilidad")]
        /// <summary>
        /// Obtiene o establece TipoResponsabilidad.
        /// </summary>
        int? TipoResponsabilidad { get; set; }
        [BsonElement("CentroPagoNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece CentroPagoNominaId.
        /// </summary>
        public string? CentroPagoNominaId { get; set; }
        
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
