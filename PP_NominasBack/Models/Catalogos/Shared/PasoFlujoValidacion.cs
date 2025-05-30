using MongoDB.Bson;
using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase PasoFlujoValidacion.
    /// </summary>
    public class PasoFlujoValidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }


        [BsonElement("autorizacionNecesaria")]
        /// <summary>
        /// Obtiene o establece AutorizacionNecesaria.
        /// </summary>
        public bool AutorizacionNecesaria { get; set; }

        [BsonElement("flujoValidacionId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece FlujoValidacionId.
        /// </summary>
        public string? FlujoValidacionId { get; set; }

        [BsonElement("notificarEnEstePaso")]
        /// <summary>
        /// Obtiene o establece NotificarEnEstePaso.
        /// </summary>
        public bool NotificarEnEstePaso { get; set; }

        [BsonElement("ordenPaso")]
        /// <summary>
        /// Obtiene o establece OrdenPaso.
        /// </summary>
        public int OrdenPaso { get; set; }

        [BsonElement("responsableId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece ResponsableId.
        /// </summary>
        public string? ResponsableId { get; set; }

        [BsonElement("tipoResponsable")]
        /// <summary>
        /// Obtiene o establece TipoResponsable.
        /// </summary>
        public int TipoResponsable { get; set; }
    
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
