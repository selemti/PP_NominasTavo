using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    /// <summary>
    /// Representa la clase HistorialValidacionDto.
    /// </summary>
    public class HistorialValidacionDto
    {
        [Display(Name = "ID del registro de validación")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Periodo de nómina validado")]
        
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; }

        [Display(Name = "Usuario que realizó la validación")]
        
        /// <summary>
        /// Obtiene o establece UsuarioValidadorId.
        /// </summary>
        public string? UsuarioValidadorId { get; set; }

        [Display(Name = "Resultado (Aprobado, Rechazado)")]
        
        /// <summary>
        /// Obtiene o establece Resultado.
        /// </summary>
        public string? Resultado { get; set; }

        [Display(Name = "Timestamp de validación")]
        
        /// <summary>
        /// Obtiene o establece FechaValidacion.
        /// </summary>
        public DateTime? FechaValidacion { get; set; }

        [Display(Name = "Comentarios de validación")]
        
        /// <summary>
        /// Obtiene o establece Observaciones.
        /// </summary>
        public string? Observaciones { get; set; }



    
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
