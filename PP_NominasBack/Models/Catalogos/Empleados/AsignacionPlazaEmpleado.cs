using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Models.Catalogos.Empleados
{
    /// <summary>  Representa la clase AsignacionPlazaEmpleado.  </summary>
    public class AsignacionPlazaEmpleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("EmpleadoId"), BsonRepresentation(BsonType.ObjectId)]
        public string? EmpleadoId { get; set; }

        [BsonElement("PlazaId"), BsonRepresentation(BsonType.ObjectId)]
        public string? PlazaId { get; set; }

        [BsonElement("Salario")]
        public decimal? Salario { get; set; }

        [BsonElement("TipoSalario")]
        public TipoSalarioEnum TipoSalario { get; set; }

        [BsonElement("FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [BsonElement("FechaFin")]
        public DateTime? FechaFin { get; set; }

        [BsonElement("Vigente")]
        public bool Vigente { get; set; }

        [BsonElement("JornadaLaboral")]
        public JornadaLaboralEnum? JornadaLaboral { get; set; }

        [BsonElement("TurnoAsignado")]
        public TipoHorarioEnum? TurnoAsignado { get; set; }

        [BsonElement("EsRotativo")]
        public bool EsRotativo { get; set; }

        [BsonElement("PeriodicidadPago")]
        public PeriodicidadEnum PeriodicidadPago { get; set; }

        [BsonElement("Comentarios")]
        public string? Comentarios { get; set; }

        [BsonElement("ultimaModificacion")]
        public DateTime FechaUltimaModificacion { get; set; }

        [BsonElement("usuarioUltimaModificacion")]
        public string? UsuarioUltimaModificacion { get; set; }
    }

}
