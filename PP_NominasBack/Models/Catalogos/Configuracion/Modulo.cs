using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase Modulo.
    /// </summary>
    public class Modulo
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("Nombre")]
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }
        [BsonElement("Descripcion")]
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }
        [BsonElement("Activo")]
        /// <summary>
        /// Obtiene o establece Activo.
        /// </summary>
        public bool? Activo { get; set; }
        
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
