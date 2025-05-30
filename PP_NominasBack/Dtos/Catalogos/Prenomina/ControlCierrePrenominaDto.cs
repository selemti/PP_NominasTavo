using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase ControlCierrePrenominaDto.
    /// </summary>
    public class ControlCierrePrenominaDto
    {
        [Display(Name = "ID del cierre de prenómina")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Periodo de nómina relacionado")]
        
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; }

        [Display(Name = "Fecha real de cierre")]
        
        /// <summary>
        /// Obtiene o establece FechaCierre.
        /// </summary>
        public DateTime? FechaCierre { get; set; }

        [Display(Name = "Usuario que cerró el periodo")]
        
        /// <summary>
        /// Obtiene o establece UsuarioCierreId.
        /// </summary>
        public string? UsuarioCierreId { get; set; }



    
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
