
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase Incidencia.
    /// </summary>
    public class Incidencia
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("TipoFalta")]
        /// <summary>
        /// Obtiene o establece TipoFalta.
        /// </summary>
        int? TipoFalta { get; set; } // Tipo de incidencia (Falta, Retardo, Permiso)

        [BsonElement("ChecadaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece ChecadaId.
        /// </summary>
        public string? ChecadaId { get; set; } // Relación con la checada

        [BsonElement("EstatusIncidencia")]
        /// <summary>
        /// Obtiene o establece EstatusIncidencia.
        /// </summary>
        public string? EstatusIncidencia { get; set; } // Estado de la incidencia (justificada o no)

        [BsonElement("DuracionRetardo")]
        /// <summary>
        /// Obtiene o establece DuracionRetardo.
        /// </summary>
        public double? DuracionRetardo { get; set; } // Duración del retardo (en horas)

        [BsonElement("Justificacion")]
        /// <summary>
        /// Obtiene o establece Justificacion.
        /// </summary>
        public string? Justificacion { get; set; } // Justificación de la incidencia (si aplica)

        [BsonElement("TipoPermiso")]
        /// <summary>
        /// Obtiene o establece TipoPermiso.
        /// </summary>
        public string? TipoPermiso { get; set; } // Tipo de permiso (vacaciones, enfermedad, etc.)
    
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
