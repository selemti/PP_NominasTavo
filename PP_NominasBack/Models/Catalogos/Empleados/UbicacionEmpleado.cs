using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PP_NominasBack.Models.Catalogos.Empleados;

/// <summary>Representa un cambio de ubicación física o asignación del empleado.</summary>
public class UbicacionEmpleado
{
    /// <summary>Identificador único del registro de ubicación.</summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    /// <summary>Identificador del empleado al que pertenece esta ubicación.</summary>
    [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
    public string? EmpleadoId { get; set; }


    /// <summary>Nombre o clave de la nueva ubicación asignada.</summary>
    [BsonElement("ubicacion")]
    public string? Ubicacion { get; set; } = string.Empty;

    /// <summary>Fecha en la que se asignó esta ubicación.</summary>
    [BsonElement("fechaAsignacion")]
    public DateTime FechaAsignacion { get; set; }

    /// <summary>Observaciones o razón del cambio (opcional).</summary>
    [BsonElement("observaciones")]
    public string? Observaciones { get; set; }

    /// <summary>Usuario que registró la modificación.</summary>
    [BsonElement("usuarioModificacion")]
    public string? UsuarioUltimaModificacion { get; set; } = string.Empty;

    /// <summary>Fecha de última modificación.</summary>
    [BsonElement("fechaModificacion")]
    public DateTime FechaUltimaModificacion { get; set; }
    public object Nombre { get; internal set; }
}
