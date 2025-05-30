using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase PreNominaIncidenciaDto.
    /// </summary>
    public class PreNominaIncidenciaDto
    {
        [Display(Name = "ID de la incidencia ObjectId")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado afectado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Periodo en que se aplicará la incidencia")]
        
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; }

        [Display(Name = "Tipo de incidencia aplicada")]
        
        /// <summary>
        /// Obtiene o establece TipoIncidenciaId.
        /// </summary>
        public string? TipoIncidenciaId { get; set; }

        [Display(Name = "Fecha en que se aplica")]
        
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime? Fecha { get; set; }

        [Display(Name = "Duración en horas o días")]
        
        /// <summary>
        /// Obtiene o establece Duracion.
        /// </summary>
        public decimal? Duracion { get; set; }

        [Display(Name = "URL del documento (si aplica)")]
        
        /// <summary>
        /// Obtiene o establece JustificanteAdjunto.
        /// </summary>
        public string? JustificanteAdjunto { get; set; }

        [Display(Name = "Aprobada, Pendiente, Rechazada")]
        
        /// <summary>
        /// Obtiene o establece Estatus.
        /// </summary>
        public string? Estatus { get; set; }



    
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
