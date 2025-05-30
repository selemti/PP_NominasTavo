using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class AsignacionPlazaEmpleadoDto
    {
        public string? Id { get; set; }
        public string EmpleadoId { get; set; } = string.Empty;
        public string? PlazaId { get; set; } = string.Empty;
        public decimal? Salario { get; set; }
        public int? TipoSalario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Vigente { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; }
        public JornadaLaboralEnum? JornadaLaboral { get; set; }
        public TipoHorarioEnum? TurnoAsignado { get; set; }
        public bool EsRotativo { get; set; }
        public PeriodicidadEnum PeriodicidadPago { get; set; }
        [Display(Name = "Comentarios")]
        public string? Comentarios { get; set; }

    }
}
