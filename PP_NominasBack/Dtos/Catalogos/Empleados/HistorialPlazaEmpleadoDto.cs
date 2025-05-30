using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase HistorialPlazaEmpleadoDto.
    /// </summary>
    public class HistorialPlazaEmpleadoDto
    {
        [Display(Name = "ID único del cambio de plaza")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado involucrado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Plaza anterior del empleado")]
        
        /// <summary>
        /// Obtiene o establece PlazaIdAnterior.
        /// </summary>
        public string? PlazaIdAnterior { get; set; }

        [Display(Name = "Nueva plaza asignada al empleado")]
        
        /// <summary>
        /// Obtiene o establece PlazaIdNueva.
        /// </summary>
        public string? PlazaIdNueva { get; set; }

        [Display(Name = "Fecha del cambio de plaza")]
        
        /// <summary>
        /// Obtiene o establece FechaCambio.
        /// </summary>
        public DateTime? FechaCambio { get; set; }

        [Display(Name = "Motivo del cambio de plaza")]
        
        /// <summary>
        /// Obtiene o establece MotivoCambio.
        /// </summary>
        public string? MotivoCambio { get; set; }



    
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
