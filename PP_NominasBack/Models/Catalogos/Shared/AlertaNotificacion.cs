using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase AlertaNotificacion.
    /// </summary>
    public class AlertaNotificacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EventoDisparador")]
        /// <summary>
        /// Obtiene o establece EventoDisparador.
        /// </summary>
        public string? EventoDisparador { get; set; }
        [BsonElement("DescripcionAlerta")]
        /// <summary>
        /// Obtiene o establece DescripcionAlerta.
        /// </summary>
        public string? DescripcionAlerta { get; set; }
        [BsonElement("TipoPeriodicidad")]
        /// <summary>
        /// Obtiene o establece TipoPeriodicidad.
        /// </summary>
        int? TipoPeriodicidad { get; set; }
        [BsonElement("MedioEnvio")]
        /// <summary>
        /// Obtiene o establece MedioEnvio.
        /// </summary>
        int? MedioEnvio { get; set; }
        [BsonElement("PlantillaMensaje")]
        /// <summary>
        /// Obtiene o establece PlantillaMensaje.
        /// </summary>
        public string? PlantillaMensaje { get; set; }
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
