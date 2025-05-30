using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    /// <summary>
    /// Representa la clase VacacionesDto.
    /// </summary>
    public class VacacionesDto
    {
        [Display(Name = "ID de la solicitud de vacaciones")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado solicitante")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Fecha de inicio de vacaciones")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fecha de regreso")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }

        [Display(Name = "Número de días solicitados")]
        
        /// <summary>
        /// Obtiene o establece DiasProgramados.
        /// </summary>
        public int? DiasProgramados { get; set; }

        [Display(Name = "Número real de días disfrutados")]
        
        /// <summary>
        /// Obtiene o establece DiasGozados.
        /// </summary>
        public int? DiasGozados { get; set; }

        [Display(Name = "Periodo vacacional aplicable")]
        
        /// <summary>
        /// Obtiene o establece PeriodoVacacionalId.
        /// </summary>
        public string? PeriodoVacacionalId { get; set; }



    
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
