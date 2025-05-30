using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaInfonavitDto.
    /// </summary>
    public class TablaInfonavitDto
    {
        [Display(Name = "ID de tabla de Infonavit")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Tipo (0 = Factor Salario, 1 = Cuota Fija)")]
        
        /// <summary>
        /// Obtiene o establece TipoDescuento.
        /// </summary>
        public int? TipoDescuento { get; set; }

        [Display(Name = "Valor aplicable del descuento")]
        
        /// <summary>
        /// Obtiene o establece ValorDescuento.
        /// </summary>
        public decimal? ValorDescuento { get; set; }

        [Display(Name = "Descripción adicional")]
        
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }

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
