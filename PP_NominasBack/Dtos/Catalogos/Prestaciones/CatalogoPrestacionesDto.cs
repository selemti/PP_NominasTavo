using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prestaciones
{
    /// <summary>
    /// Representa la clase CatalogoPrestacionesDto.
    /// </summary>
    public class CatalogoPrestacionesDto
    {
        [Display(Name = "ID de la prestación")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre de la prestación")]
        
        /// <summary>
        /// Obtiene o establece NombrePrestacion.
        /// </summary>
        public string? NombrePrestacion { get; set; }

        [Display(Name = "DescripcionPrestacion")]
        
        /// <summary>
        /// Obtiene o establece DescripcionPrestacion.
        /// </summary>
        public string? DescripcionPrestacion { get; set; }

        [Display(Name = "Empresa relacionada")]
        
        /// <summary>
        /// Obtiene o establece AplicaEmpresaId.
        /// </summary>
        public string? AplicaEmpresaId { get; set; }

        [Display(Name = "División relacionada")]
        
        /// <summary>
        /// Obtiene o establece AplicaDivisionId.
        /// </summary>
        public string? AplicaDivisionId { get; set; }



    
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
