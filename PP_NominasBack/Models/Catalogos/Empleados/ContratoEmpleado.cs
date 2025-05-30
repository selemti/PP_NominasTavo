using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase ContratoEmpleado.
    /// </summary>
    public class ContratoEmpleado
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
        [BsonElement("TipoContrato")]
        /// <summary>
        /// Obtiene o establece TipoContrato.
        /// </summary>
        int? TipoContrato { get; set; }
        [BsonElement("FechaInicioContrato")]
        /// <summary>
        /// Obtiene o establece FechaInicioContrato.
        /// </summary>
        public DateTime? FechaInicioContrato { get; set; }
        [BsonElement("FechaFinContrato")]
        /// <summary>
        /// Obtiene o establece FechaFinContrato.
        /// </summary>
        public DateTime? FechaFinContrato { get; set; }
        [BsonElement("vigente")]
        /// <summary>
        /// Obtiene o establece vigente.
        /// </summary>
        public bool? vigente { get; set; }
        
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
