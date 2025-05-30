using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO para contactos de emergencia de un empleado.</summary>
    public class ContactoEmergenciaDto
    {
        /// <summary>Nombre completo del contacto.</summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del Contacto")]
        public string? Nombre { get; set; }

        public string? EmpleadoId { get; set; }

        /// <summary>Parentesco o relación con el empleado.</summary>
        [Display(Name = "Parentesco")]
        public string? Parentesco { get; set; }

        /// <summary>Teléfono principal de contacto.</summary>
        [Display(Name = "Teléfono de Contacto")]
        public string? Telefono { get; set; }

        /// <summary>¿Este contacto es el principal?</summary>
        [Display(Name = "Principal")]
        public bool Principal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        public string? UsuarioUltimaModificacion { get; set; }
    }
}
