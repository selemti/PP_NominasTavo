
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase EmpleadoCompensacionDto.
    /// </summary>
    public class EmpleadoCompensacionDto
    {
        [Display(Name = "Id")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "EmpleadoId")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "CompensacionId")]
        
        /// <summary>
        /// Obtiene o establece CompensacionId.
        /// </summary>
        public string? CompensacionId { get; set; }

        [Display(Name = "Valor")]
        
        /// <summary>
        /// Obtiene o establece Valor.
        /// </summary>
        public decimal? Valor { get; set; }

        [Display(Name = "Tipo de asignación")]
        
        /// <summary>
        /// Obtiene o establece TipoAsignacion.
        /// </summary>
        public int? TipoAsignacion { get; set; }

        [Display(Name = "Fórmula de cálculo")]
        
        /// <summary>
        /// Obtiene o establece Formula.
        /// </summary>
        public string? Formula { get; set; }

        [Display(Name = "Periodicidad")]
        
        /// <summary>
        /// Obtiene o establece Periodicidad.
        /// </summary>
        public int? Periodicidad { get; set; }

        [Display(Name = "Fecha inicio")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fecha fin")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }

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
