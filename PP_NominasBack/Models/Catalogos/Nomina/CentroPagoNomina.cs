using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase CentroPagoNomina.
    /// </summary>
    public class CentroPagoNomina
    {
        [BsonId]
        [BsonElement("Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [BsonElement("NombreCentroPago")]
        /// <summary>
        /// Obtiene o establece NombreCentroPago.
        /// </summary>
        public string? NombreCentroPago { get; set; }
        [BsonElement("FechaCorteQuincena1")]
        /// <summary>
        /// Obtiene o establece FechaCorteQuincena1.
        /// </summary>
        int? FechaCorteQuincena1 { get; set; }
        [BsonElement("FechaCorteQuincena2")]
        /// <summary>
        /// Obtiene o establece FechaCorteQuincena2.
        /// </summary>
        int? FechaCorteQuincena2 { get; set; }
        [BsonElement("FechaPagoQuincena1")]
        /// <summary>
        /// Obtiene o establece FechaPagoQuincena1.
        /// </summary>
        int? FechaPagoQuincena1 { get; set; }
        [BsonElement("FechaPagoQuincena2")]
        /// <summary>
        /// Obtiene o establece FechaPagoQuincena2.
        /// </summary>
        int? FechaPagoQuincena2 { get; set; }
        
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
