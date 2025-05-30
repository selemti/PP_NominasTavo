using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase RegistroImssDto.
    /// </summary>
    public class RegistroImssDto
    {
        [Display(Name = "ID del registro")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Fecha de alta ante IMSS")]
        
        /// <summary>
        /// Obtiene o establece FechaAlta.
        /// </summary>
        public DateTime? FechaAlta { get; set; }

        [Display(Name = "Fecha de baja ante IMSS")]
        
        /// <summary>
        /// Obtiene o establece FechaBaja.
        /// </summary>
        public DateTime? FechaBaja { get; set; }

        [Display(Name = "Número de Seguridad Social")]
        
        /// <summary>
        /// Obtiene o establece Nss.
        /// </summary>
        public string? Nss { get; set; }



    
    /// <summary>
    /// Fecha de la última modificación del documento.
    /// </summary>
    public DateTime FechaUltimaModificacion { get; set; }

    /// <summary>
    /// Identificador del usuario que realizó la última modificación.
    /// </summary>
    public string? UsuarioUltimaModificacion { get; set; }
}
}
