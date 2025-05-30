using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase TipoIncidenciaDto.
    /// </summary>
    public class TipoIncidenciaDto
    {
        [Display(Name = "ID del tipo de incidencia")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del tipo (Incapacidad, Permiso, etc.)")]
        
        /// <summary>
        /// Obtiene o establece NombreTipoIncidencia.
        /// </summary>
        public string? NombreTipoIncidencia { get; set; }

        [Display(Name = "Descripción breve del tipo")]
        
        /// <summary>
        /// Obtiene o establece DescripcionTipoIncidencia.
        /// </summary>
        public string? DescripcionTipoIncidencia { get; set; }

        [Display(Name = "Indica si necesita documento")]
        
        /// <summary>
        /// Obtiene o establece RequiereJustificante.
        /// </summary>
        public bool? RequiereJustificante { get; set; }



    
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
