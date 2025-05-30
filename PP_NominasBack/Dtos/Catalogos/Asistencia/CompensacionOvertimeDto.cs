using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase CompensacionOvertimeDto.
    /// </summary>
    public class CompensacionOvertimeDto
    {
        [Display(Name = "ID del tipo de compensación")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código corto de compensación")]
        
        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        public string? Codigo { get; set; }

        [Display(Name = "Nombre del tipo de compensación")]
        
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }

        [Display(Name = "Descripción detallada")]
        
        /// <summary>
        /// Obtiene o establece Descripcion.
        /// </summary>
        public string? Descripcion { get; set; }



    
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
