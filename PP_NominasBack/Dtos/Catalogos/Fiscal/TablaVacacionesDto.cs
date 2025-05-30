using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase TablaVacacionesDto.
    /// </summary>
    public class TablaVacacionesDto
    {
        [Display(Name = "ID del rango de antigüedad")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Años mínimos cumplidos")]
        
        /// <summary>
        /// Obtiene o establece AniosAntiguedadMinimo.
        /// </summary>
        public int? AniosAntiguedadMinimo { get; set; }

        [Display(Name = "Años máximos cumplidos")]
        
        /// <summary>
        /// Obtiene o establece AniosAntiguedadMaximo.
        /// </summary>
        public int? AniosAntiguedadMaximo { get; set; }

        [Display(Name = "Días de vacaciones otorgados")]
        
        /// <summary>
        /// Obtiene o establece DiasVacaciones.
        /// </summary>
        public int? DiasVacaciones { get; set; }

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
