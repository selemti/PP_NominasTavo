using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase HistorialPlazaEmpleado.
    /// </summary>
    public class HistorialPlazaEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }
        [BsonElement("PlazaIdAnterior")]
        /// <summary>
        /// Obtiene o establece PlazaIdAnterior.
        /// </summary>
        public string? PlazaIdAnterior { get; set; }
        [BsonElement("PlazaIdNueva")]
        /// <summary>
        /// Obtiene o establece PlazaIdNueva.
        /// </summary>
        public string? PlazaIdNueva { get; set; }
        [BsonElement("FechaCambio")]
        /// <summary>
        /// Obtiene o establece FechaCambio.
        /// </summary>
        public DateTime? FechaCambio { get; set; }
        [BsonElement("MotivoCambio")]
        /// <summary>
        /// Obtiene o establece MotivoCambio.
        /// </summary>
        public string? MotivoCambio { get; set; }
        
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
