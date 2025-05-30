using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase ContactoDto.
    /// </summary>
    public class ContactoDto
    {
        [Display(Name = "ID del contacto")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código de entidad relacionada")]
        
        /// <summary>
        /// Obtiene o establece TipoEntidad.
        /// </summary>
        public string? TipoEntidad { get; set; }

        [Display(Name = "ID de la entidad relacionada")]
        
        /// <summary>
        /// Obtiene o establece EntidadId.
        /// </summary>
        public string? EntidadId { get; set; }

        [Display(Name = "Nombre del contacto")]
        
        /// <summary>
        /// Obtiene o establece NombreContacto.
        /// </summary>
        public string? NombreContacto { get; set; }

        [Display(Name = "Teléfono de contacto")]
        
        /// <summary>
        /// Obtiene o establece TelefonoContacto.
        /// </summary>
        public string? TelefonoContacto { get; set; }

        [Display(Name = "Parentesco o relación")]
        
        /// <summary>
        /// Obtiene o establece Parentesco.
        /// </summary>
        public string? Parentesco { get; set; }



    
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
