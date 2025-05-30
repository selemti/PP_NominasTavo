using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase ContratoEmpleadoDto.
    /// </summary>
    public class ContratoEmpleadoDto
    {
        [Display(Name = "ID del contrato laboral")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Tipo de contrato (0 = Indeterminado, 1 = Temporal, etc.)")]
        
        /// <summary>
        /// Obtiene o establece TipoContrato.
        /// </summary>
        public int? TipoContrato { get; set; }

        [Display(Name = "FechaInicioContrato")]
        
        /// <summary>
        /// Obtiene o establece FechaInicioContrato.
        /// </summary>
        public DateTime? FechaInicioContrato { get; set; }

        [Display(Name = "Fin de vigencia (nullable)")]
        
        /// <summary>
        /// Obtiene o establece FechaFinContrato.
        /// </summary>
        public DateTime? FechaFinContrato { get; set; }

        [Display(Name = "Indica si es el contrato activo")]
        
        /// <summary>
        /// Obtiene o establece vigente.
        /// </summary>
        public bool? vigente { get; set; }



    
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
