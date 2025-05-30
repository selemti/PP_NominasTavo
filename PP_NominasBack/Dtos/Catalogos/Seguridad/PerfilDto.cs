using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    /// <summary>
    /// Representa la clase PerfilDto.
    /// </summary>
    public class PerfilDto
    {
        [Display(Name = "ID del perfil")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del perfil")]
        
        /// <summary>
        /// Obtiene o establece NombrePerfil.
        /// </summary>
        public string? NombrePerfil { get; set; }

        [Display(Name = "Descripción funcional")]
        
        /// <summary>
        /// Obtiene o establece DescripcionPerfil.
        /// </summary>
        public string? DescripcionPerfil { get; set; }



    
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
