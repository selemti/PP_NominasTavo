using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase IncapacidadMedicaDto.
    /// </summary>
    public class IncapacidadMedicaDto
    {
        [Display(Name = "ID único de la incapacidad")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado afectado")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Tipo (0 = Enfermedad, 1 = Maternidad, 2 = Riesgo)")]
        
        /// <summary>
        /// Obtiene o establece TipoIncapacidad.
        /// </summary>
        public int? TipoIncapacidad { get; set; }

        [Display(Name = "Días autorizados por el IMSS")]
        
        /// <summary>
        /// Obtiene o establece DiasIncapacidad.
        /// </summary>
        public int? DiasIncapacidad { get; set; }

        [Display(Name = "Folio de validación ante IMSS")]
        
        /// <summary>
        /// Obtiene o establece FolioImss.
        /// </summary>
        public string? FolioImss { get; set; }

        [Display(Name = "Fecha de inicio de la incapacidad")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fecha de fin de la incapacidad")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }



    
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
