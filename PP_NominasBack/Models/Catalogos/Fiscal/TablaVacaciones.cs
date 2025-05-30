using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaVacaciones.
    /// </summary>
    public class TablaVacaciones
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("AniosAntiguedadMinimo")]
        /// <summary>
        /// Obtiene o establece AniosAntiguedadMinimo.
        /// </summary>
        int? AniosAntiguedadMinimo { get; set; }
        [BsonElement("AniosAntiguedadMaximo")]
        /// <summary>
        /// Obtiene o establece AniosAntiguedadMaximo.
        /// </summary>
        int? AniosAntiguedadMaximo { get; set; }
        [BsonElement("DiasVacaciones")]
        /// <summary>
        /// Obtiene o establece DiasVacaciones.
        /// </summary>
        int? DiasVacaciones { get; set; }
        [BsonElement("EjercicioFiscal")]
        /// <summary>
        /// Obtiene o establece EjercicioFiscal.
        /// </summary>
        int? EjercicioFiscal { get; set; }
        
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
