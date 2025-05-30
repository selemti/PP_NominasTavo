using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

/// <summary>Catálogo de tipos de contrato válidos para empleados.</summary>
namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary> Representa la clase TipoContrato.</summary>
    public class TipoContrato
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }


        [BsonElement("NombreContrato")]
        /// <summary>Obtiene o establece NombreContrato. </summary>
        public string? NombreContrato { get; set; } = string.Empty;
        [BsonElement("DescripcionContrato")]
        /// <summary>Obtiene o establece DescripcionContrato.</summary>
        public string? DescripcionContrato { get; set; } = string.Empty;

        [BsonElement("ClaveSat")]
        /// <summary>Obtiene o establece Clave del SAT </summary>
        public string? ClaveSat { get; set; } = string.Empty;

        [BsonElement("Activo")]
        /// <summary>Obtiene o establece si el contrato esta activo</summary>
        public bool Activo { get; set; } = true;

        /// <summary>Fecha de la última modificación del documento.</summary>
        [BsonElement("ultimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Identificador del usuario que realizó la última modificación.</summary>
        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; }
}
}
