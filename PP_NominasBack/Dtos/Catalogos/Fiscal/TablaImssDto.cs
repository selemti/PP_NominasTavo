using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaImssDto.
    /// </summary>
    public class TablaImssDto
    {
        [Display(Name = "ID de la cuota IMSS")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Concepto de cuota (ej. Enfermedad y Maternidad)")]
        
        /// <summary>
        /// Obtiene o establece Concepto.
        /// </summary>
        public string? Concepto { get; set; }

        [Display(Name = "Porcentaje de aportación patronal")]
        
        /// <summary>
        /// Obtiene o establece PorcentajePatronal.
        /// </summary>
        public decimal? PorcentajePatronal { get; set; }

        [Display(Name = "Porcentaje de aportación del trabajador")]
        
        /// <summary>
        /// Obtiene o establece PorcentajeObrero.
        /// </summary>
        public decimal? PorcentajeObrero { get; set; }

        [Display(Name = "Si aplica solo a salario mínimo (bool)")]
        
        /// <summary>
        /// Obtiene o establece SalarioMinimoAplica.
        /// </summary>
        public bool? SalarioMinimoAplica { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        
        /// <summary>
        /// Obtiene o establece EjercicioFiscal.
        /// </summary>
        public int? EjercicioFiscal { get; set; }



    
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
