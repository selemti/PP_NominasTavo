using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase PlazaDto.
    /// </summary>
    public class PlazaDto
    {
        [Display(Name = "ID de la plaza")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código único de la plaza")]
        
        /// <summary>
        /// Obtiene o establece ClavePlaza.
        /// </summary>
        public string? ClavePlaza { get; set; }

        [Display(Name = "Nombre asignado a la plaza")]
        
        /// <summary>
        /// Obtiene o establece NombrePlaza.
        /// </summary>
        public string? NombrePlaza { get; set; }

        [Display(Name = "Puesto de la plaza")]
        
        /// <summary>
        /// Obtiene o establece PuestoId.
        /// </summary>
        public string? PuestoId { get; set; }

        [Display(Name = "Departamento al que pertenece la plaza")]
        
        /// <summary>
        /// Obtiene o establece DepartamentoId.
        /// </summary>
        public string? DepartamentoId { get; set; }

        [Display(Name = "Estatus (0 = Vacante, 1 = Ocupada)")]
        
        /// <summary>
        /// Obtiene o establece EstatusPlaza.
        /// </summary>
        public int? EstatusPlaza { get; set; }



    
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
