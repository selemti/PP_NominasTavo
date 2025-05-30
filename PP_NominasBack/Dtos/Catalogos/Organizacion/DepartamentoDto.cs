using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase DepartamentoDto.
    /// </summary>
    public class DepartamentoDto
    {
        [Display(Name = "ID del departamento")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código del departamento")]
        
        /// <summary>
        /// Obtiene o establece ClaveDepartamento.
        /// </summary>
        public string? ClaveDepartamento { get; set; }

        [Display(Name = "Nombre del departamento")]
        
        /// <summary>
        /// Obtiene o establece NombreDepartamento.
        /// </summary>
        public string? NombreDepartamento { get; set; }

        [Display(Name = "División a la que pertenece")]
        
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; }



    
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
