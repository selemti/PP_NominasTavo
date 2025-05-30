using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ConfiguracionNominaDto.
    /// </summary>
    public class ConfiguracionNominaDto
    {
        [Display(Name = "ID de configuración")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Grupo empresarial relacionado")]
        
        /// <summary>
        /// Obtiene o establece GrupoEmpresaId.
        /// </summary>
        public string? GrupoEmpresaId { get; set; }

        [Display(Name = "(0 = Quincenal, 1 = Semanal, 2 = Mensual)")]
        
        /// <summary>
        /// Obtiene o establece TipoNomina.
        /// </summary>
        public int? TipoNomina { get; set; }

        [Display(Name = "Días específicos de pago (ej: 5, 20)")]
        
        /// <summary>
        /// Obtiene o establece DiasPago.
        /// </summary>
        int? DiasPago { get; set; }

        [Display(Name = "Centro de trabajo relacionado")]
        
        /// <summary>
        /// Obtiene o establece CentroTrabajoId.
        /// </summary>
        public string? CentroTrabajoId { get; set; }



    
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
