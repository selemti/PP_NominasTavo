using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase MovimientoFondoAhorroDto.
    /// </summary>
    public class MovimientoFondoAhorroDto
    {
        [Display(Name = "ID del movimiento")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Fondo relacionado")]
        
        /// <summary>
        /// Obtiene o establece FondoAhorroId.
        /// </summary>
        public string? FondoAhorroId { get; set; }

        [Display(Name = "(0 = Aportación, 1 = Retiro, 2 = Interés generado)")]
        
        /// <summary>
        /// Obtiene o establece TipoMovimiento.
        /// </summary>
        public int? TipoMovimiento { get; set; }

        [Display(Name = "Monto del movimiento")]
        
        /// <summary>
        /// Obtiene o establece Monto.
        /// </summary>
        public decimal? Monto { get; set; }

        [Display(Name = "Fecha de operación")]
        
        /// <summary>
        /// Obtiene o establece FechaMovimiento.
        /// </summary>
        public DateTime? FechaMovimiento { get; set; }

        [Display(Name = "Descripción breve del movimiento")]
        
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }



    
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
