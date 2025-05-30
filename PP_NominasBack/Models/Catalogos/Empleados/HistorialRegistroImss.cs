using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase HistorialRegistroImss.
    /// </summary>
    public class HistorialRegistroImss
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("Nss")]
        /// <summary>
        /// Obtiene o establece Nss.
        /// </summary>
        public string? Nss { get; set; }
        [BsonElement("RegistroPatronalId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece RegistroPatronalId.
        /// </summary>
        public string? RegistroPatronalId { get; set; }
        [BsonElement("FechaAlta")]
        /// <summary>
        /// Obtiene o establece FechaAlta.
        /// </summary>
        public DateTime? FechaAlta { get; set; }
        [BsonElement("FechaBaja")]
        /// <summary>
        /// Obtiene o establece FechaBaja.
        /// </summary>
        public DateTime? FechaBaja { get; set; }
    
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
