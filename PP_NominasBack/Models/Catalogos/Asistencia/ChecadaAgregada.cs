using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase ChecadaAgregada.
    /// </summary>
    public class ChecadaAgregada
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

        [BsonElement("Fecha")]
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime Fecha { get; set; }

        [BsonElement("HoraEntrada")]
        /// <summary>
        /// Obtiene o establece HoraEntrada.
        /// </summary>
        public string? HoraEntrada { get; set; }

        [BsonElement("HoraSalida")]
        /// <summary>
        /// Obtiene o establece HoraSalida.
        /// </summary>
        public string? HoraSalida { get; set; }

        [BsonElement("Observaciones")]
        /// <summary>
        /// Obtiene o establece Observaciones.
        /// </summary>
        public string? Observaciones { get; set; }

    
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
