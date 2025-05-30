using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>Representa un documento entregado por el empleado.</summary>
    public class DocumentoEmpleado
    {
        /// <summary>Identificador único del documento.</summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? EmpleadoId { get; set; }


        /// <summary>ID del tipo de documento (referencia a TipoArchivoEmpleado).</summary>
        [BsonElement("tipoId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? TipoId { get; set; }

        /// <summary>Nombre del archivo entregado.</summary>
        [BsonElement("nombreArchivo")]
        public string? NombreArchivo { get; set; }

        /// <summary>Ruta o URL del archivo escaneado.</summary>
        [BsonElement("urlArchivo")]
        public string? UrlArchivo { get; set; }

        /// <summary>Fecha en la que se entregó el documento.</summary>
        [BsonElement("fechaEntrega")]
        public DateTime FechaEntrega { get; set; } = DateTime.UtcNow;

        /// <summary>¿El documento fue validado por recursos humanos?</summary>
        [BsonElement("validado")]
        public bool Validado { get; set; } = false;

        /// <summary>Usuario que registró o modificó el documento.</summary>
        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; }

        /// <summary>Fecha de la última modificación.</summary>
        [BsonElement("fechaUltimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }
    }
}
