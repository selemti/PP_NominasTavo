using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase TabuladorSalarialDto.
    /// </summary>
    public class TabuladorSalarialDto
    {
        [Display(Name = "ID del tabulador")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Puesto relacionado")]
        
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }

        [Display(Name = "Salario mínimo para puesto")]
        
        /// <summary>
        /// Obtiene o establece SalarioMinimo.
        /// </summary>
        public decimal? SalarioMinimo { get; set; }

        [Display(Name = "Salario máximo para puesto")]
        
        /// <summary>
        /// Obtiene o establece SalarioMaximo.
        /// </summary>
        public decimal? SalarioMaximo { get; set; }



    
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
