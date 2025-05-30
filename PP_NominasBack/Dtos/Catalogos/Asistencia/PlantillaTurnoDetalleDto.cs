using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase PlantillaTurnoDetalleDto.
    /// </summary>
    public class PlantillaTurnoDetalleDto
    {
        [Display(Name = "ID del detalle de turno")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "ID de la plantilla base mensual")]
        
        /// <summary>
        /// Obtiene o establece PlantillaId.
        /// </summary>
        public string? PlantillaId { get; set; }

        [Display(Name = "Fecha del turno asignado")]
        
        /// <summary>
        /// Obtiene o establece Fecha.
        /// </summary>
        public DateTime? Fecha { get; set; }

        [Display(Name = "Turno aplicado ese día")]
        
        /// <summary>
        /// Obtiene o establece TurnoId.
        /// </summary>
        public string? TurnoId { get; set; }

        [Display(Name = "Plaza a la que se asigna el turno")]
        
        /// <summary>
        /// Obtiene o establece PlazaId.
        /// </summary>
        public string? PlazaId { get; set; }



    
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
