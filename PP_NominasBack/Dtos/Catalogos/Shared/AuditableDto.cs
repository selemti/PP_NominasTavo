using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase AuditableDto.
    /// </summary>
    public class AuditableDto
    {
        [Display(Name = "Fecha de creación del registro")]
        
        /// <summary>
        /// Obtiene o establece FechaCreacion.
        /// </summary>
        public DateTime? FechaCreacion { get; set; }

        [Display(Name = "Fecha de última modificación")]
        
        /// <summary>
        /// Obtiene o establece FechaModificacion.
        /// </summary>
        public DateTime? FechaUltimaModificacion { get; set; }

        [Display(Name = "Usuario que creó el registro")]
        
        /// <summary>
        /// Obtiene o establece UsuarioCreadorId.
        /// </summary>
        public string? UsuarioCreadorId { get; set; }

        [Display(Name = "Usuario que modificó el registro")]
        
        /// <summary>
        /// Obtiene o establece UsuarioModificadorId.
        /// </summary>
        public string? UsuarioUltimaModificacion { get; set; }
   }
}
