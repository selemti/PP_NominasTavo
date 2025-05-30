using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase PlantillaMensualDto.
    /// </summary>
    public class PlantillaMensualDto
    {
        [Display(Name = "ID de la plantilla mensual")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Mes aplicable (1-12)")]
        
        /// <summary>
        /// Obtiene o establece Mes.
        /// </summary>
        public int? Mes { get; set; }

        [Display(Name = "Año aplicable")]
        
        /// <summary>
        /// Obtiene o establece AO.
        /// </summary>
        public int? AO { get; set; }

        [Display(Name = "Horario usado en el mes")]
        
        /// <summary>
        /// Obtiene o establece HorarioPlantillaId.
        /// </summary>
        public string? HorarioPlantillaId { get; set; }



    
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
