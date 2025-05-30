using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados;

/// <summary>
/// Modelo que representa al empleado dentro del sistema.
/// </summary>
public class Empleado
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? NumeroEmpleado { get; set; } = string.Empty;

    public string? Persona { get; set; }

    
    public string? Nss { get; set; } = string.Empty;

    public DateTime FechaIngreso { get; set; } = DateTime.Now;

    public TipoContratoEnum TipoContrato { get; set; }

    public TipoHorarioEnum TipoHorario { get; set; }

    public EstatusEmpleadoEnum EstatusEmpleado { get; set; }

    /// <summary>Referencia al ID del registro de datos de pago</summary>
    [BsonRepresentation(BsonType.ObjectId)]
    public string? DatosPagoId { get; set; }

    /// <summary>ID principal de la asignación activa</summary>
    [BsonRepresentation(BsonType.ObjectId)]
    public string? AsignacionId { get; set; }

    /// <summary>IDs de asignaciones históricas</summary>
    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> AsignacionHistorialIds { get; set; } = new();

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> HistorialUbicacionIds { get; set; } = new();

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> RegistroImssIds { get; set; } = new();

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> HorarioIds { get; set; } = new();

    public List<DocumentoEmpleado> Documentos { get; set; } = new();

    public List<ContactoEmergencia> ContactosEmergencia { get; set; } = new();

    public string? CorreoCorporativo { get; set; } = string.Empty;

    public string? UsuarioRed { get; set; } = string.Empty;

    public string? IdBiometrico { get; set; } = string.Empty;

    public string? FotoPerfilUrl { get; set; }

    public DateTime FechaUltimaModificacion { get; set; }

    public string? UsuarioUltimaModificacion { get; set; } = string.Empty;
}
