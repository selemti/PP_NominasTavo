using MongoDB.Bson;
using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase FlujoValidacion.
    /// </summary>
    public class FlujoValidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("activo")]
        /// <summary>
        /// Obtiene o establece Activo.
        /// </summary>
        public bool Activo { get; set; }

        [BsonElement("descripcionFlujo")]
        /// <summary>
        /// Obtiene o establece DescripcionFlujo.
        /// </summary>
        public string? DescripcionFlujo { get; set; }

        [BsonElement("nombreFlujo")]
        /// <summary>
        /// Obtiene o establece NombreFlujo.
        /// </summary>
        public string? NombreFlujo { get; set; }

        [BsonElement("procesoRelacionado")]
        /// <summary>
        /// Obtiene o establece ProcesoRelacionado.
        /// </summary>
        public string? ProcesoRelacionado { get; set; }
    
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
