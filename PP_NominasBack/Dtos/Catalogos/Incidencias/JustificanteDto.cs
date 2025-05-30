using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase JustificanteDto.
    /// </summary>
    public class JustificanteDto
    {
        [Display(Name = "ID del justificante de incidencia")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Tipo de documento (certificado médico, etc.)")]
        
        /// <summary>
        /// Obtiene o establece TipoJustificante.
        /// </summary>
        public int? TipoJustificante { get; set; }

        [Display(Name = "URL del archivo digital")]
        
        /// <summary>
        /// Obtiene o establece UrlDocumento.
        /// </summary>
        public string? UrlDocumento { get; set; }

        [Display(Name = "Fecha de emisión del documento")]
        
        /// <summary>
        /// Obtiene o establece FechaEmision.
        /// </summary>
        public DateTime? FechaEmision { get; set; }



    
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
