using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase Contacto.
    /// </summary>
    public class Contacto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("TipoEntidad")]
        /// <summary>
        /// Obtiene o establece TipoEntidad.
        /// </summary>
        public string? TipoEntidad { get; set; }
        [BsonElement("EntidadId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EntidadId.
        /// </summary>
        public string? EntidadId { get; set; }
        [BsonElement("NombreContacto")]
        /// <summary>
        /// Obtiene o establece NombreContacto.
        /// </summary>
        public string? NombreContacto { get; set; }
        [BsonElement("TelefonoContacto")]
        /// <summary>
        /// Obtiene o establece TelefonoContacto.
        /// </summary>
        public string? TelefonoContacto { get; set; }
        [BsonElement("Parentesco")]
        /// <summary>
        /// Obtiene o establece Parentesco.
        /// </summary>
        public string? Parentesco { get; set; }
        
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
