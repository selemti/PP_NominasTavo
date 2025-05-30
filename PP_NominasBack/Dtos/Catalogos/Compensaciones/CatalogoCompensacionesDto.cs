using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase CatalogoCompensacionesDto.
    /// </summary>
    public class CatalogoCompensacionesDto
    {
        [Display(Name = "ID de la compensación")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Tipo (0 = Bono, 1 = Comisión, 2 = Premio)")]
        
        /// <summary>
        /// Obtiene o establece TipoCompensacion.
        /// </summary>
        public int? TipoCompensacion { get; set; }

        [Display(Name = "Nombre del concepto")]
        
        /// <summary>
        /// Obtiene o establece NombreCompensacion.
        /// </summary>
        public string? NombreCompensacion { get; set; }

        [Display(Name = "DescripcionCompensacion")]
        
        /// <summary>
        /// Obtiene o establece DescripcionCompensacion.
        /// </summary>
        public string? DescripcionCompensacion { get; set; }

        [Display(Name = "Empresa relacionada (opcional)")]
        
        /// <summary>
        /// Obtiene o establece AplicaEmpresaId.
        /// </summary>
        public string? AplicaEmpresaId { get; set; }

        [Display(Name = "División relacionada (opcional)")]
        
        /// <summary>
        /// Obtiene o establece AplicaDivisionId.
        /// </summary>
        public string? AplicaDivisionId { get; set; }



    
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
