using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase TipoEventoBiometrico.
    /// </summary>
    public class TipoEventoBiometrico
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombreEvento")]
        /// <summary>
        /// Obtiene o establece NombreEvento.
        /// </summary>
        public string? NombreEvento { get; set; }
        [BsonElement("DescripcionEvento")]
        /// <summary>
        /// Obtiene o establece DescripcionEvento.
        /// </summary>
        public string? DescripcionEvento { get; set; }
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
