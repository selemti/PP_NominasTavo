using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>Teléfono asociado a una persona o contacto.</summary>
    public class Telefono
    {
        /// <summary>Identificador único interno del teléfono.</summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>Tipo de teléfono (Ej: Celular, Casa, Oficina, Emergencia).</summary>
        
        public TipoTelefono Tipo { get; set; }

        /// <summary>Clave lada nacional o internacional (Ej: 55, 33, +52).</summary>
        public string? ClaveLada { get; set; }

        /// <summary>Número telefónico sin lada.</summary>
        
        [Phone]
        public string? Numero { get; set; }

        /// <summary>Extensión interna (si aplica).</summary>
        public string? Extension { get; set; }

        /// <summary>Indica si este es el número principal de contacto.</summary>
        public bool Principal { get; set; } = false;

        /// <summary>Comentario adicional o nota sobre el teléfono.</summary>
        public string? Observaciones { get; set; }
        
        /// <summary>Fecha de la última modificación del documento.</summary>
        [BsonElement("ultimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Identificador del usuario que realizó la última modificación.</summary>
        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
