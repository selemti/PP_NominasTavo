
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase Checada.
    /// </summary>
    public class Checada
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

        [BsonElement("FechaHora")]
        /// <summary>
        /// Obtiene o establece FechaHora.
        /// </summary>
        public DateTime? FechaHora { get; set; }

        [BsonElement("TipoEvento")]
        /// <summary>
        /// Obtiene o establece TipoEvento.
        /// </summary>
        int? TipoEvento { get; set; }

        [BsonElement("DispositivoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece DispositivoId.
        /// </summary>
        public string? DispositivoId { get; set; }

        
        /// <summary>
        /// Obtiene o establece Auditable.
        /// </summary>
        

        // Nueva propiedad calculada para Horas Trabajadas
        [BsonElement("HorasTrabajadas")]
        /// <summary>
        /// Obtiene o establece HorasTrabajadas.
        /// </summary>
        public List<double>? HorasTrabajadas { get; set; } // Horas calculadas de la diferencia entre Entrada y Salida

        // Método para calcular HorasTrabajadas (si es necesario)
        /// <summary>
        /// Ejecuta el método CalcularHorasTrabajadas.
        /// </summary>
        public double CalcularHorasTrabajadas(DateTime entrada, DateTime salida)
        {
            return (salida - entrada).TotalHours;
        }
    
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
