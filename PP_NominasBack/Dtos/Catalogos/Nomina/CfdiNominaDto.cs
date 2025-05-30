using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase CfdiNominaDto.
    /// </summary>
    public class CfdiNominaDto
    {
        [Display(Name = "ID del CFDI")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Recibo relacionado")]
        
        /// <summary>
        /// Obtiene o establece ReciboNominaId.
        /// </summary>
        public string? ReciboNominaId { get; set; }

        [Display(Name = "UUID del comprobante SAT")]
        
        /// <summary>
        /// Obtiene o establece Uuid.
        /// </summary>
        public string? Uuid { get; set; }

        [Display(Name = "Sello digital del CFDI")]
        
        /// <summary>
        /// Obtiene o establece SelloDigital.
        /// </summary>
        public string? SelloDigital { get; set; }

        [Display(Name = "Fecha de timbrado SAT")]
        
        /// <summary>
        /// Obtiene o establece FechaTimbre.
        /// </summary>
        public DateTime? FechaTimbre { get; set; }



    
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
