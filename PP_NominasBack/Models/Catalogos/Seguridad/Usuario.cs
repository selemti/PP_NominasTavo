using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    /// <summary>
    /// Representa la clase Usuario.
    /// </summary>
    public class Usuario
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        string Id { get; set; }

        [BsonElement("NombreUsuario")]
        /// <summary>
        /// Obtiene o establece NombreUsuario.
        /// </summary>
        public string? NombreUsuario { get; set; }
        [BsonElement("CorreoElectronico")]
        /// <summary>
        /// Obtiene o establece CorreoElectronico.
        /// </summary>
        public string? CorreoElectronico { get; set; }
        [BsonElement("PerfilId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PerfilId.
        /// </summary>
        public string? PerfilId { get; set; }
        [BsonElement("EstatusUsuario")]
        /// <summary>
        /// Obtiene o establece EstatusUsuario.
        /// </summary>
        int? EstatusUsuario { get; set; }
        
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
