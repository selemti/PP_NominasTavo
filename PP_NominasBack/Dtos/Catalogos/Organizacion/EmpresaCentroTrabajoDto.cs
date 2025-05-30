using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase EmpresaCentroTrabajoDto.
    /// </summary>
    public class EmpresaCentroTrabajoDto
    {
        [Display(Name = "ID único de la relación empresa - centro de trabajo")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empresa relacionada")]
        
        /// <summary>
        /// Obtiene o establece GrupoEmpresaId.
        /// </summary>
        public string? GrupoEmpresaId { get; set; }

        [Display(Name = "Centro de trabajo relacionado")]
        
        /// <summary>
        /// Obtiene o establece CentroTrabajoId.
        /// </summary>
        public string? CentroTrabajoId { get; set; }

        [Display(Name = "Indica si la relación está activa")]
        
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; }



    
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
