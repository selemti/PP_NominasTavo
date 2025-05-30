using MongoDB.Bson;
using System;
using MongoDB.Bson.Serialization.Attributes;
namespace PP_NominasBack.Models.Catalogos.Organización
{
    /// <summary>
    /// Representa la clase HistorialUbicacionEmpleado.
    /// </summary>
    public class HistorialUbicacionEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("empleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [BsonElement("ubicacionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece UbicacionId.
        /// </summary>
        public string? UbicacionId { get; set; }

        [BsonElement("fechaInicio")]
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }

    
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