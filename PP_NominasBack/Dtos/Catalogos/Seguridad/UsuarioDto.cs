using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    /// <summary>
    /// Representa la clase UsuarioDto.
    /// </summary>
    public class UsuarioDto
    {
        [Display(Name = "ID del usuario")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre de login")]
        
        /// <summary>
        /// Obtiene o establece NombreUsuario.
        /// </summary>
        public string? NombreUsuario { get; set; }

        [Display(Name = "Correo corporativo")]
        
        /// <summary>
        /// Obtiene o establece CorreoElectronico.
        /// </summary>
        public string? CorreoElectronico { get; set; }

        [Display(Name = "Perfil asignado")]
        
        /// <summary>
        /// Obtiene o establece PerfilId.
        /// </summary>
        public string? PerfilId { get; set; }

        [Display(Name = "Estatus de cuenta")]
        
        /// <summary>
        /// Obtiene o establece EstatusUsuario.
        /// </summary>
        public int? EstatusUsuario { get; set; }



    
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
