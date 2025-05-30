
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase CalendarioLaboralDto.
    /// </summary>
    public class CalendarioLaboralDto
    {
        [Display(Name = "ID del evento en calendario")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Fecha del evento")]
        
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime? Fecha { get; set; }

        [Display(Name = "(0 = Laboral normal, 1 = Feriado oficial, 2 = Descanso especial)")]
        
        /// <summary>
        /// Obtiene o establece TipoDia.
        /// </summary>
        public int? TipoDia { get; set; }

        [Display(Name = "Descripción breve del evento")]
        
        /// <summary>
        /// Obtiene o establece DescripcionEvento.
        /// </summary>
        public string? DescripcionEvento { get; set; }

        [Display(Name = "Empresa relacionada (opcional)")]
        
        /// <summary>
        /// Obtiene o establece EmpresaId.
        /// </summary>
        public string? EmpresaId { get; set; }

        [Display(Name = "División relacionada (opcional)")]
        
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; }

        [Display(Name = "Vigente")]
        
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
