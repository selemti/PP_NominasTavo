using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase TipoEventoBiometricoDto.
    /// </summary>
    public class TipoEventoBiometricoDto
    {
        [Display(Name = "ID del tipo de evento")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del evento (entrada, salida, comida, etc.)")]
        
        /// <summary>
        /// Obtiene o establece NombreEvento.
        /// </summary>
        public string? NombreEvento { get; set; }

        [Display(Name = "Descripción detallada del evento")]
        
        /// <summary>
        /// Obtiene o establece DescripcionEvento.
        /// </summary>
        public string? DescripcionEvento { get; set; }

        [Display(Name = "Estatus activo del tipo de evento")]
        
        /// <summary>
        /// Obtiene o establece Activo.
        /// </summary>
        public bool? Activo { get; set; }



    
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
