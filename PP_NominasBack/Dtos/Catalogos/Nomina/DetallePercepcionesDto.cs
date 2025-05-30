using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase DetallePercepcionesDto.
    /// </summary>
    public class DetallePercepcionesDto
    {
        [Display(Name = "ID del detalle de percepción")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Recibo de nómina asociado")]
        
        /// <summary>
        /// Obtiene o establece ReciboNominaId.
        /// </summary>
        public string? ReciboNominaId { get; set; }

        [Display(Name = "Concepto de percepción aplicada")]
        
        /// <summary>
        /// Obtiene o establece TipoCompensacionId.
        /// </summary>
        public string? TipoCompensacionId { get; set; }

        [Display(Name = "Monto de la percepción")]
        
        /// <summary>
        /// Obtiene o establece Monto.
        /// </summary>
        public decimal? Monto { get; set; }

        [Display(Name = "(0 = Gravado, 1 = Exento, 2 = Excedente)")]
        
        /// <summary>
        /// Obtiene o establece TipoFiscalizacion.
        /// </summary>
        public int? TipoFiscalizacion { get; set; }



    
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
