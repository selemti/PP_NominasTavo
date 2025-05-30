// Dtos/Catalogos/Nomina/FiniquitoLiquidacionDto.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase FiniquitoLiquidacionDto.
    /// </summary>
    public class FiniquitoLiquidacionDto
    {
        [Display(Name = "Empleado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Fecha de finiquito")]
        
        /// <summary>
        /// Obtiene o establece FechaFiniquito.
        /// </summary>
        public DateTime FechaFiniquito { get; set; }

        [Display(Name = "ISR calculado")]
        
        /// <summary>
        /// Obtiene o establece IsrCalculado.
        /// </summary>
        public decimal IsrCalculado { get; set; }

        [Display(Name = "Total finiquito")]
        
        /// <summary>
        /// Obtiene o establece TotalFiniquito.
        /// </summary>
        public decimal TotalFiniquito { get; set; }

        [Display(Name = "Conceptos")]
        /// <summary>
        /// Obtiene o establece Conceptos.
        /// </summary>
        public List<ConceptoFiniquitoDto> Conceptos { get; set; } = new();
    
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
