using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase DetalleDeduccionesDto.
    /// </summary>
    public class DetalleDeduccionesDto
    {
        [Display(Name = "ID del detalle de deducción")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Recibo de nómina asociado")]
        
        /// <summary>
        /// Obtiene o establece ReciboNominaId.
        /// </summary>
        public string? ReciboNominaId { get; set; }

        [Display(Name = "Concepto de deducción aplicada")]
        
        /// <summary>
        /// Obtiene o establece TipoDeduccionId.
        /// </summary>
        public string? TipoDeduccionId { get; set; }

        [Display(Name = "Monto de la deducción")]
        
        /// <summary>
        /// Obtiene o establece Monto.
        /// </summary>
        public decimal? Monto { get; set; }



    
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
