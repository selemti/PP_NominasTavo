using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase OrganigramaDto.
    /// </summary>
    public class OrganigramaDto
    {
        [Display(Name = "ID único del nodo")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "División o UDN relacionada")]
        
        /// <summary>
        /// Obtiene o establece DivisionId.
        /// </summary>
        public string? DivisionId { get; set; }

        [Display(Name = "Puesto del nodo")]
        
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }

        [Display(Name = "Centro de costo asignado")]
        
        /// <summary>
        /// Obtiene o establece CentroCostoId.
        /// </summary>
        public string? CentroCostoId { get; set; }

        [Display(Name = "Padre del nodo en estructura")]
        
        /// <summary>
        /// Obtiene o establece NodoPadreId.
        /// </summary>
        public string? NodoPadreId { get; set; }

        [Display(Name = "Nivel jerárquico")]
        
        /// <summary>
        /// Obtiene o establece Nivel.
        /// </summary>
        public int? Nivel { get; set; }



    
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
