using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Vacaciones
{
    /// <summary>
    /// Representa la clase PeriodoVacacional.
    /// </summary>
    public class PeriodoVacacional
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("Anio")]
        /// <summary>
        /// Obtiene o establece Anio.
        /// </summary>
        int? Anio { get; set; }
        [BsonElement("DiasAsignados")]
        /// <summary>
        /// Obtiene o establece DiasAsignados.
        /// </summary>
        int? DiasAsignados { get; set; }

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
