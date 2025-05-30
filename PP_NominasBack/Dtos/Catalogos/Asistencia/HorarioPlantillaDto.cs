using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HorarioPlantillaDto.
    /// </summary>
    public class HorarioPlantillaDto
    {
        [Display(Name = "ID de la plantilla de horarios")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre de la plantilla")]
        
        /// <summary>
        /// Obtiene o establece NombrePlantilla.
        /// </summary>
        public string? NombrePlantilla { get; set; }

        [Display(Name = "Descripción breve del horario")]
        
        /// <summary>
        /// Obtiene o establece DescripcionPlantilla.
        /// </summary>
        public string? DescripcionPlantilla { get; set; }

        [Display(Name = "Turno base de la plantilla")]
        
        /// <summary>
        /// Obtiene o establece TurnoId.
        /// </summary>
        public string? TurnoId { get; set; }



    
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
