using MongoDB.Bson;
using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase DestinatarioAlerta.
    /// </summary>
    public class DestinatarioAlerta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("alertaId"), BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Obtiene o establece AlertaId.
        /// </summary>
        public string? AlertaId { get; set; }

        [BsonElement("tipoDestinatario")]
        /// <summary>
        /// Obtiene o establece TipoDestinatario.
        /// </summary>
        public int TipoDestinatario { get; set; }

        [BsonElement("valorDestino")]
        /// <summary>
        /// Obtiene o establece ValorDestino.
        /// </summary>
        public string? ValorDestino { get; set; }
    
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
