
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ReciboNomina.
    /// </summary>
    public class ReciboNomina
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
        public string? EmpleadoId { get; set; } // Relación con Empleado

        [BsonElement("PeriodoNominaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; } // Relación con Periodo de Nómina

        [BsonElement("HorasExtrasTrabajadas")]
        /// <summary>
        /// Obtiene o establece HorasExtrasTrabajadas.
        /// </summary>
        public double HorasExtrasTrabajadas { get; set; } // Horas extras trabajadas

        [BsonElement("HorasExtrasAutorizadas")]
        /// <summary>
        /// Obtiene o establece HorasExtrasAutorizadas.
        /// </summary>
        public double HorasExtrasAutorizadas { get; set; } // Horas extras autorizadas

        [BsonElement("TotalPercepciones")]
        /// <summary>
        /// Obtiene o establece TotalPercepciones.
        /// </summary>
        public decimal TotalPercepciones { get; set; } // Total de percepciones

        [BsonElement("TotalDeducciones")]
        /// <summary>
        /// Obtiene o establece TotalDeducciones.
        /// </summary>
        public decimal TotalDeducciones { get; set; } // Total de deducciones

        [BsonElement("TotalNeto")]
        /// <summary>
        /// Obtiene o establece TotalNeto.
        /// </summary>
        public decimal TotalNeto { get; set; } // Total neto

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
