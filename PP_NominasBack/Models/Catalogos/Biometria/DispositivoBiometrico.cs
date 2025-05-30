using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase DispositivoBiometrico.
    /// </summary>
    public class DispositivoBiometrico
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("Modelo")]
        /// <summary>
        /// Obtiene o establece Modelo.
        /// </summary>
        public string? Modelo { get; set; }
        [BsonElement("NumeroSerie")]
        /// <summary>
        /// Obtiene o establece NumeroSerie.
        /// </summary>
        public string? NumeroSerie { get; set; }
        [BsonElement("IpAsignada")]
        /// <summary>
        /// Obtiene o establece IpAsignada.
        /// </summary>
        public string? IpAsignada { get; set; }
        [BsonElement("TipoDispositivo")]
        /// <summary>
        /// Obtiene o establece TipoDispositivo.
        /// </summary>
        int? TipoDispositivo { get; set; }
        
        /// <summary>
        /// Obtiene o establece Auditable.
        /// </summary>
        
        [BsonElement("CentroId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece CentroId.
        /// </summary>
        public string? CentroId { get; set; }
    
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
