
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase Turno.
    /// </summary>
    public class Turno
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombreTurno")]
        /// <summary>
        /// Obtiene o establece NombreTurno.
        /// </summary>
        public string? NombreTurno { get; set; }

        [BsonElement("HoraEntrada")]
        /// <summary>
        /// Obtiene o establece HoraEntrada.
        /// </summary>
        public string? HoraEntrada { get; set; } // Hora de entrada

        [BsonElement("HoraSalida")]
        /// <summary>
        /// Obtiene o establece HoraSalida.
        /// </summary>
        public string? HoraSalida { get; set; } // Hora de salida

        [BsonElement("TipoTurno")]
        /// <summary>
        /// Obtiene o establece TipoTurno.
        /// </summary>
        int? TipoTurno { get; set; } // Tipo de turno (Fijo, Rotativo)

        
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
