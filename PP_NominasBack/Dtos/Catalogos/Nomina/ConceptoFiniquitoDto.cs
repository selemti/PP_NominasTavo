// Dtos/Catalogos/Nomina/ConceptoFiniquitoDto.cs
using System.ComponentModel.DataAnnotations;

using System;
namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ConceptoFiniquitoDto.
    /// </summary>
    public class ConceptoFiniquitoDto
    {
        [Display(Name = "FiniquitoLiquidacionId")]
        
        /// <summary>
        /// Obtiene o establece FiniquitoLiquidacionId.
        /// </summary>
        public string? FiniquitoLiquidacionId { get; set; }

        [Display(Name = "Código")]
        
        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        public string? Codigo { get; set; }

        [Display(Name = "Descripción")]
        
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }

        [Display(Name = "Es percepción")]
        /// <summary>
        /// Obtiene o establece EsPercepcion.
        /// </summary>
        public bool EsPercepcion { get; set; }

        [Display(Name = "Importe")]
        
        /// <summary>
        /// Obtiene o establece Importe.
        /// </summary>
        public decimal Importe { get; set; }
    
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
