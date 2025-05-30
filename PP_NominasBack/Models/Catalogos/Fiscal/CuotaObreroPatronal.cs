using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase CuotaObreroPatronal.
    /// </summary>
    public class CuotaObreroPatronal
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
        [BsonElement("PorcentajePatron")]
        /// <summary>
        /// Obtiene o establece PorcentajePatron.
        /// </summary>
        public decimal? PorcentajePatron { get; set; }
        [BsonElement("PorcentajeEmpleado")]
        /// <summary>
        /// Obtiene o establece PorcentajeEmpleado.
        /// </summary>
        public decimal? PorcentajeEmpleado { get; set; }
        [BsonElement("VigenciaInicio")]
        /// <summary>
        /// Obtiene o establece VigenciaInicio.
        /// </summary>
        public DateTime? VigenciaInicio { get; set; }
        [BsonElement("VigenciaFin")]
        /// <summary>
        /// Obtiene o establece VigenciaFin.
        /// </summary>
        public DateTime? VigenciaFin { get; set; }
        
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
