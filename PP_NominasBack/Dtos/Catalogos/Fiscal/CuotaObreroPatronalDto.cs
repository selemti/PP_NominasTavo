using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    /// <summary>
    /// Representa la clase CuotaObreroPatronalDto.
    /// </summary>
    public class CuotaObreroPatronalDto
    {
        [Display(Name = "ID de la cuota")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Concepto (Ej: Enfermedad, Retiro)")]
        
        /// <summary>
        /// Obtiene o establece Concepto.
        /// </summary>
        public string? Concepto { get; set; }

        [Display(Name = "% Aportación patronal (actualizable)")]
        
        /// <summary>
        /// Obtiene o establece PorcentajePatron.
        /// </summary>
        public decimal? PorcentajePatron { get; set; }

        [Display(Name = "% Aportación empleado")]
        
        /// <summary>
        /// Obtiene o establece PorcentajeEmpleado.
        /// </summary>
        public decimal? PorcentajeEmpleado { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        
        /// <summary>
        /// Obtiene o establece VigenciaInicio.
        /// </summary>
        public DateTime? VigenciaInicio { get; set; }

        [Display(Name = "Fecha de fin de vigencia")]
        
        /// <summary>
        /// Obtiene o establece VigenciaFin.
        /// </summary>
        public DateTime? VigenciaFin { get; set; }



    
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
