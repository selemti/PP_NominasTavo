using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase PreNominaIncidencia.
    /// </summary>
    public class PreNominaIncidencia
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("PeriodoNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; }
        [BsonElement("TipoIncidenciaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece TipoIncidenciaId.
        /// </summary>
        public string? TipoIncidenciaId { get; set; }
        [BsonElement("Fecha")]
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime? Fecha { get; set; }
        [BsonElement("Duracion")]
        /// <summary>
        /// Obtiene o establece Duracion.
        /// </summary>
        public decimal? Duracion { get; set; }
        [BsonElement("JustificanteAdjunto")]
        /// <summary>
        /// Obtiene o establece JustificanteAdjunto.
        /// </summary>
        public string? JustificanteAdjunto { get; set; }
        [BsonElement("Estatus")]
        /// <summary>
        /// Obtiene o establece Estatus.
        /// </summary>
        public string? Estatus { get; set; }
        
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
