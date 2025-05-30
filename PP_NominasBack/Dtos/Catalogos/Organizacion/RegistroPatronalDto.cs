using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase RegistroPatronalDto.
    /// </summary>
    public class RegistroPatronalDto
    {
        [Display(Name = "Nombre del registro patronal")]
        
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }

        [Display(Name = "RFC de la entidad patronal")]
        
        /// <summary>
        /// Obtiene o establece Rfc.
        /// </summary>
        public string? Rfc { get; set; }

        [Display(Name = "Número oficial del registro patronal")]
        
        /// <summary>
        /// Obtiene o establece NumeroRegistro.
        /// </summary>
        public string? NumeroRegistro { get; set; }

        [Display(Name = "Subdelegación del IMSS correspondiente")]
        
        /// <summary>
        /// Obtiene o establece Subdelegacion.
        /// </summary>
        public string? Subdelegacion { get; set; }

    
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
