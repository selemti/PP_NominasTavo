using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organización
{
    /// <summary>
    /// Representa la clase HistorialUbicacionEmpleadoDto.
    /// </summary>
    public class HistorialUbicacionEmpleadoDto
    {
        [Display(Name = "Empleado asignado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Ubicación asignada")]
        
        /// <summary>
        /// Obtiene o establece UbicacionId.
        /// </summary>
        public string? UbicacionId { get; set; }

        [Display(Name = "Inicio de asignación")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fin de asignación")]
        
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
