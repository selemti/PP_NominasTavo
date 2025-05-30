using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase DivisionDto.
    /// </summary>
    public class DivisionDto
    {
        [Display(Name = "ID de la división")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Grupo empresarial al que pertenece")]
        
        /// <summary>
        /// Obtiene o establece GrupoEmpresaId.
        /// </summary>
        public string? GrupoEmpresaId { get; set; }

        [Display(Name = "Código de la división")]
        
        /// <summary>
        /// Obtiene o establece ClaveDivision.
        /// </summary>
        public string? ClaveDivision { get; set; }

        [Display(Name = "Nombre de la división")]
        
        /// <summary>
        /// Obtiene o establece NombreDivision.
        /// </summary>
        public string? NombreDivision { get; set; }



    
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
