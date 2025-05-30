using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    /// <summary>
    /// Representa la clase PeriodoVacacionalDto.
    /// </summary>
    public class PeriodoVacacionalDto
    {
        [Display(Name = "ID del periodo vacacional anual")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Año aplicable")]
        
        /// <summary>
        /// Obtiene o establece Anio.
        /// </summary>
        public int? Anio { get; set; }

        [Display(Name = "Días asignados anuales")]
        
        /// <summary>
        /// Obtiene o establece DiasAsignados.
        /// </summary>
        public int? DiasAsignados { get; set; }



    
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
