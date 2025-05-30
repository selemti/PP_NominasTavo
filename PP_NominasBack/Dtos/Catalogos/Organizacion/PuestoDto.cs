using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organización
{
    /// <summary>
    /// Representa la clase PuestoDto.
    /// </summary>
    public class PuestoDto
    {
        [Display(Name = "Enum funcional extendido para RH")]
        
        /// <summary>
        /// Obtiene o establece NivelPuesto.
        /// </summary>
        public int? NivelPuesto { get; set; }

    
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
