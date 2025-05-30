using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase HistorialIncidenciaDto.
    /// </summary>
    public class HistorialIncidenciaDto
    {
        [Display(Name = "ID del historial de cambios")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Incidencia relacionada")]
        
        /// <summary>
        /// Obtiene o establece IncidenciaId.
        /// </summary>
        public string? IncidenciaId { get; set; }

        [Display(Name = "Fecha del cambio registrado")]
        
        /// <summary>
        /// Obtiene o establece FechaCambio.
        /// </summary>
        public DateTime? FechaCambio { get; set; }

        [Display(Name = "Descripción del cambio realizado")]
        
        /// <summary>
        /// Obtiene o establece DescripcionCambio.
        /// </summary>
        public string? DescripcionCambio { get; set; }



    
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
