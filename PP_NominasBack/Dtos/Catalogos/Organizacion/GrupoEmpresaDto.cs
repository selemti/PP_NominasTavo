using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase GrupoEmpresaDto.
    /// </summary>
    public class GrupoEmpresaDto
    {
        [Display(Name = "ID del grupo empresarial")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código interno del grupo")]
        
        /// <summary>
        /// Obtiene o establece Clave.
        /// </summary>
        public string? Clave { get; set; }

        [Display(Name = "Nombre del grupo")]
        
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }

        [Display(Name = "RFC del grupo")]
        
        /// <summary>
        /// Obtiene o establece Rfc.
        /// </summary>
        public string? Rfc { get; set; }



    
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
