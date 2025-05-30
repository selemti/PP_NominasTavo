using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>DTO que representa la ubicación física asignada a un empleado.</summary>
    public class UbicacionEmpleadoDto
    {
        /// <summary>ID único de la ubicación.</summary>
        [Display(Name = "ID")]
        public string? Id { get; set; }
        public string? EmpleadoId { get; set; }


        /// <summary>Nombre del lugar o ubicación asignada.</summary>
        [Display(Name = "Nombre de la Ubicación")]
        public string? Nombre { get; set; }

        /// <summary>Descripción opcional de la ubicación.</summary>
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        /// <summary>¿Ubicación activa actualmente?</summary>
        [Display(Name = "Ubicación Activa")]
        public bool Activa { get; set; }

        /// <summary>Fecha en la que se asignó esta ubicación.</summary>
        [Display(Name = "Fecha de Asignación")]
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        public string? UsuarioUltimaModificacion { get; set; }
    }
}
