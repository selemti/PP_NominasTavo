using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaIsrDto.
    /// </summary>
    public class TablaIsrDto
    {
        [Display(Name = "ID del rango de ISR")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Límite inferior del rango")]
        
        /// <summary>
        /// Obtiene o establece LimiteInferior.
        /// </summary>
        public decimal? LimiteInferior { get; set; }

        [Display(Name = "Límite superior del rango")]
        
        /// <summary>
        /// Obtiene o establece LimiteSuperior.
        /// </summary>
        public decimal? LimiteSuperior { get; set; }

        [Display(Name = "Cuota fija aplicable")]
        
        /// <summary>
        /// Obtiene o establece CuotaFija.
        /// </summary>
        public decimal? CuotaFija { get; set; }

        [Display(Name = "Porcentaje aplicable al excedente")]
        
        /// <summary>
        /// Obtiene o establece PorcentajeExcedente.
        /// </summary>
        public decimal? PorcentajeExcedente { get; set; }

        [Display(Name = "Periodo aplicable (0 = Diario, 1 = Semanal, 2 = Quincenal, 3 = Mensual)")]
        
        /// <summary>
        /// Obtiene o establece Periodo.
        /// </summary>
        public int? Periodo { get; set; }

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
