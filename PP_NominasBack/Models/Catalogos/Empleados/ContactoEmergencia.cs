using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Empleados;

/// <summary>Representa a una persona de contacto en caso de emergencia para el empleado.</summary>
public class ContactoEmergencia
{
    /// <summary>Identificador único del contacto.</summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    /// <summary>Nombre completo del contacto.</summary>
    [BsonElement("nombre")]
    public string? Nombre { get; set; } = string.Empty;

    /// <summary>Parentesco con el empleado.</summary>
    [BsonElement("parentesco")]
    public string? Parentesco { get; set; } = string.Empty;

    /// <summary>Teléfono principal del contacto.</summary>
    [BsonElement("telefono")]
    public string? Telefono { get; set; } = string.Empty;

    /// <summary>Teléfono alterno (opcional).</summary>
    [BsonElement("telefonoAlterno")]
    public string? TelefonoAlterno { get; set; }

    /// <summary>Correo electrónico del contacto (opcional).</summary>
    [BsonElement("correoElectronico")]
    public string? CorreoElectronico { get; set; }

    /// <summary>Usuario que registró el contacto.</summary>
    [BsonElement("usuarioModificacion")]
    public string? UsuarioUltimaModificacion { get; set; } = string.Empty;

    /// <summary>Fecha de la última modificación.</summary>
    [BsonElement("fechaModificacion")]
    public DateTime FechaUltimaModificacion { get; set; }
    public string? EmpleadoId { get; internal set; }
}
