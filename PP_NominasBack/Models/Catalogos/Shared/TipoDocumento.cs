using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class TipoDocumento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string? Clave { get; set; }  // Ej. "INE"
        public string? Nombre { get; set; } // Ej. "Identificación oficial"
        public bool RequiereVigencia { get; set; }
        public bool Obligatorio { get; set; }
    }
}
