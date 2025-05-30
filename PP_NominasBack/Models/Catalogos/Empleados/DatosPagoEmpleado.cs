using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase DatosPagoEmpleado.
    /// </summary>
    public class DatosPagoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("BancoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece BancoId.
        /// </summary>
        public string? BancoId { get; set; }
        [BsonElement("CuentaBancaria")]
        /// <summary>
        /// Obtiene o establece CuentaBancaria.
        /// </summary>
        public string? CuentaBancaria { get; set; }
        [BsonElement("FormaPago")]
        /// <summary>
        /// Obtiene o establece FormaPago.
        /// </summary>
        int? FormaPago { get; set; }
        [BsonElement("Vigente")]
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; }
        [BsonElement("FechaInicio")]
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }
        [BsonElement("FechaFin")]
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }
        
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
