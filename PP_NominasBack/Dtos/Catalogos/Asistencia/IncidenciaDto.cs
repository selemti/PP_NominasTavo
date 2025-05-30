
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase IncidenciaDto.
    /// </summary>
    public class IncidenciaDto
    {
        [Display(Name = "Tipo de Incidencia")]
        /// <summary>
        /// Obtiene o establece TipoFalta.
        /// </summary>
        public int? TipoFalta { get; set; } // Tipo de incidencia (Falta, Retardo, Permiso)

        [Display(Name = "ID de la Checada asociada")]
        
        /// <summary>
        /// Obtiene o establece ChecadaId.
        /// </summary>
        public string? ChecadaId { get; set; } // Relación con la checada

        [Display(Name = "Estatus de la Incidencia")]
        
        /// <summary>
        /// Obtiene o establece EstatusIncidencia.
        /// </summary>
        public string? EstatusIncidencia { get; set; } // Estado de la incidencia

        [Display(Name = "Duración del Retardo (en horas)")]
        /// <summary>
        /// Obtiene o establece DuracionRetardo.
        /// </summary>
        public double? DuracionRetardo { get; set; } // Duración del retardo

        [Display(Name = "Justificación de la Incidencia")]
        
        /// <summary>
        /// Obtiene o establece Justificacion.
        /// </summary>
        public string? Justificacion { get; set; } // Justificación de la incidencia

        [Display(Name = "Tipo de Permiso")]
        
        /// <summary>
        /// Obtiene o establece TipoPermiso.
        /// </summary>
        public string? TipoPermiso { get; set; } // Tipo de permiso (enfermedad, vacaciones, etc.)
    
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
