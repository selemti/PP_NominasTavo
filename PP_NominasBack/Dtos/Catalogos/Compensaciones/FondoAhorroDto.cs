using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase FondoAhorroDto.
    /// </summary>
    public class FondoAhorroDto
    {
        [Display(Name = "ID del fondo de ahorro")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado participante")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Saldo acumulado")]
        
        /// <summary>
        /// Obtiene o establece SaldoActual.
        /// </summary>
        public decimal? SaldoActual { get; set; }

        [Display(Name = "PorcentajeAportacion")]
        
        /// <summary>
        /// Obtiene o establece PorcentajeAportacion.
        /// </summary>
        public decimal? PorcentajeAportacion { get; set; }

        [Display(Name = "Fondo activo o cerrado")]
        
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
