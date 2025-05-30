using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HorarioPlantilla.
    /// </summary>
    public class HorarioPlantilla
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombrePlantilla")]
        /// <summary>
        /// Obtiene o establece NombrePlantilla.
        /// </summary>
        public string? NombrePlantilla { get; set; }
        [BsonElement("DescripcionPlantilla")]
        /// <summary>
        /// Obtiene o establece DescripcionPlantilla.
        /// </summary>
        public string? DescripcionPlantilla { get; set; }
        [BsonElement("TurnoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece TurnoId.
        /// </summary>
        public string? TurnoId { get; set; }
        
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
