using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>
    /// Representa un tipo de documento que debe o puede ser entregado por el empleado.
    /// </summary>
    public class TipoArchivoEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>Código corto o clave del documento (ej. CURP, INE).</summary>
        [BsonElement("codigo")]
        public string? Codigo { get; set; } = string.Empty;

        /// <summary>Nombre completo del documento.</summary>
        [BsonElement("nombre")]
        public string? Nombre { get; set; } = string.Empty;

        /// <summary>Indica si el documento es obligatorio.</summary>
        [BsonElement("requerido")]
        public bool? Requerido { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        [BsonElement("fechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que realizó la última modificación.</summary>
        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
