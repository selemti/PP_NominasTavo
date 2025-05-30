using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Deducciones
{
    /// <summary>
    /// Representa la clase EmpleadoDeduccionDto.
    /// </summary>
    public class EmpleadoDeduccionDto
    {
        [Display(Name = "ID de la asignación")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado afectado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Deducción aplicada")]
        
        /// <summary>
        /// Obtiene o establece DeduccionId.
        /// </summary>
        public string? DeduccionId { get; set; }

        [Display(Name = "Valor a deducir")]
        
        /// <summary>
        /// Obtiene o establece Valor.
        /// </summary>
        public decimal? Valor { get; set; }

        [Display(Name = "(0 = Única, 1 = Mensual, 2 = Quincenal)")]
        
        /// <summary>
        /// Obtiene o establece Periodicidad.
        /// </summary>
        public int? Periodicidad { get; set; }

        [Display(Name = "Inicio de la deducción")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fin (nullable)")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }



    
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
