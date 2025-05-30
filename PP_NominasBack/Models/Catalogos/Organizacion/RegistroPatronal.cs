using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase RegistroPatronal.
    /// </summary>
    public class RegistroPatronal
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
        [BsonElement("Rfc")]
        /// <summary>
        /// Obtiene o establece Rfc.
        /// </summary>
        public string? Rfc { get; set; }
        [BsonElement("NumeroRegistro")]
        /// <summary>
        /// Obtiene o establece NumeroRegistro.
        /// </summary>
        public string? NumeroRegistro { get; set; }
        [BsonElement("Subdelegacion")]
        /// <summary>
        /// Obtiene o establece Subdelegacion.
        /// </summary>
        public string? Subdelegacion { get; set; }
    
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
