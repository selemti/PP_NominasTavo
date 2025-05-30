using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO para representar la asignación de plaza a un empleado.</summary>
    public class AsignacionPlazaEmpleadoDto
    {
        /// <summary>ID de la asignación.</summary>
        [Display(Name = "ID de asignación")]
        public string? Id { get; set; }

        /// <summary>ID del empleado asignado.</summary>
        [Display(Name = "Empleado")]
        public string? EmpleadoId { get; set; }

        /// <summary>ID de la plaza asignada.</summary>
        
        [Display(Name = "Plaza")]
        public string? PlazaId { get; set; }

        /// <summary>Salario asignado en esta plaza.</summary>
        [Display(Name = "Salario")]
        public decimal? Salario { get; set; }

        /// <summary>Tipo de salario (0 = Mensual, 1 = Diario, 2 = Hora).</summary>
        [Display(Name = "Tipo de salario")]
        public int? TipoSalario { get; set; }

        /// <summary>Fecha de inicio de la asignación.</summary>
        [Display(Name = "Fecha de inicio")]
        public DateTime? FechaInicio { get; set; }

        /// <summary>Fecha de término de la asignación (si aplica).</summary>
        [Display(Name = "Fecha de término")]
        public DateTime? FechaFin { get; set; }

        /// <summary>Indica si la asignación está vigente.</summary>
        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; } = true;


        [Display(Name = "Jornada laboral")]
        public JornadaLaboralEnum? JornadaLaboral { get; set; }

        [Display(Name = "Turno asignado")]
        public TipoHorarioEnum? TurnoAsignado { get; set; }

        [Display(Name = "¿Es rotativo?")]
        public bool? EsRotativo { get; set; }

        [Display(Name = "Periodicidad de pago")]
        public PeriodicidadEnum PeriodicidadPago { get; set; }

        [Display(Name = "Comentarios")]
        public string? Comentarios { get; set; }


        /// <summary>Última fecha de modificación del registro.</summary>
        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que realizó la última modificación.</summary>
        [Display(Name = "Usuario de modificación")]
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
