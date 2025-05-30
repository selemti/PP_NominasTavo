using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO del historial de registros IMSS para el empleado.</summary>
    public class HistorialRegistroImssDto
    {
        /// <summary>ID único del historial.</summary>
        [Display(Name = "ID")]
        public string? Id { get; set; }

        /// <summary>ID del empleado.</summary>
        
        [Display(Name = "Empleado")]
        public string? EmpleadoId { get; set; }

        /// <summary>Número de seguridad social.</summary>
        
        [Display(Name = "NSS")]
        public string? Nss { get; set; }

        /// <summary>ID del registro patronal.</summary>
        
        [Display(Name = "Registro patronal")]
        public string? RegistroPatronalId { get; set; }

        /// <summary>Fecha de alta en historial.</summary>
        [Display(Name = "Fecha de alta")]
        public DateTime? FechaAlta { get; set; }

        /// <summary>Fecha de baja en historial.</summary>
        [Display(Name = "Fecha de baja")]
        public DateTime? FechaBaja { get; set; }

        /// <summary>Fecha de última modificación.</summary>
        public DateTime FechaUltimaModificacion { get; set; }

        /// <summary>Usuario que modificó el historial.</summary>
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
