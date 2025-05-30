using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase EmpleadoContactoDto.
    /// </summary>
    public class EmpleadoContactoDto
    {
        [Display(Name = "ID del contacto")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "ID del empleado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Nombre completo del contacto")]
        
        /// <summary>
        /// Obtiene o establece NombreContacto.
        /// </summary>
        public string? NombreContacto { get; set; }

        [Display(Name = "Parentesco (enum)")]
        
        /// <summary>
        /// Obtiene o establece Parentesco.
        /// </summary>
        public int? Parentesco { get; set; }



    
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
