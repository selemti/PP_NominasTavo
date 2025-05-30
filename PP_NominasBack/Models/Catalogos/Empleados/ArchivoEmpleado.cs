using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase ArchivoEmpleado.
    /// </summary>
    public class ArchivoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("TipoArchivo")]
        /// <summary>
        /// Obtiene o establece TipoArchivo.
        /// </summary>
        int? TipoArchivo { get; set; }
        [BsonElement("UrlArchivo")]
        /// <summary>
        /// Obtiene o establece UrlArchivo.
        /// </summary>
        public string? UrlArchivo { get; set; }
        [BsonElement("FechaCarga")]
        /// <summary>
        /// Obtiene o establece FechaCarga.
        /// </summary>
        public DateTime? FechaCarga { get; set; }
        [BsonElement("Vigente")]
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; }
        
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
