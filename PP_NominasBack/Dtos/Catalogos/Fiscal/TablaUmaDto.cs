using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaUmaDto.
    /// </summary>
    public class TablaUmaDto
    {
        [Display(Name = "ID de la UMA")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Valor monetario de la UMA")]
        
        /// <summary>
        /// Obtiene o establece ValorUma.
        /// </summary>
        public decimal? ValorUma { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        
        /// <summary>
        /// Obtiene o establece FechaInicioVigencia.
        /// </summary>
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha fin de vigencia")]
        
        /// <summary>
        /// Obtiene o establece FechaFinVigencia.
        /// </summary>
        public DateTime? FechaFinVigencia { get; set; }

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
