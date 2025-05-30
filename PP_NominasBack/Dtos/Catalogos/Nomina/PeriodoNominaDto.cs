using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase PeriodoNominaDto.
    /// </summary>
    public class PeriodoNominaDto
    {
        [Display(Name = "(0 = Administrativo, 1 = Crew, 2 = Overhead)")]
        
        /// <summary>
        /// Obtiene o establece TipoNomina.
        /// </summary>
        public int? TipoNomina { get; set; }

    
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
