using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PP_NominasBack.Models.Catalogos.Empleados;

public class Empleado
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? NumeroEmpleado { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? Persona { get; set; }

    public string? Nss { get; set; }

    public DateTime FechaIngreso { get; set; } = DateTime.Now;

    public TipoContratoEnum TipoContrato { get; set; }

    public TipoHorarioEnum TipoHorario { get; set; }

    public EstatusEmpleadoEnum EstatusEmpleado { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? DatosPagoId { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string? AsignacionId { get; set; }

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

    public string? CorreoCorporativo { get; set; }

    public string? UsuarioRed { get; set; }

    public string? IdBiometrico { get; set; }

    public string? FotoPerfilUrl { get; set; }

    public DateTime FechaUltimaModificacion { get; set; }

    public string? UsuarioUltimaModificacion { get; set; }
}
