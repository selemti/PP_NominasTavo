using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase ConfiguracionGlobalDto.
    /// </summary>
    public class ConfiguracionGlobalDto
    {
        [Display(Name = "ID de la configuración")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Categoría de configuración (ej. Nómina, Asistencia)")]
        
        /// <summary>
        /// Obtiene o establece CategoriaConfiguracion.
        /// </summary>
        public string? CategoriaConfiguracion { get; set; }

        [Display(Name = "Clave interna de configuración")]
        
        /// <summary>
        /// Obtiene o establece ClaveConfiguracion.
        /// </summary>
        public string? ClaveConfiguracion { get; set; }

        [Display(Name = "ValorConfiguracion")]
        
        /// <summary>
        /// Obtiene o establece ValorConfiguracion.
        /// </summary>
        public string? ValorConfiguracion { get; set; }

        [Display(Name = "DescripcionConfiguracion")]
        
        /// <summary>
        /// Obtiene o establece DescripcionConfiguracion.
        /// </summary>
        public string? DescripcionConfiguracion { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        
        /// <summary>
        /// Obtiene o establece FechaInicioVigencia.
        /// </summary>
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha de fin de vigencia (nullable)")]
        
        /// <summary>
        /// Obtiene o establece FechaFinVigencia.
        /// </summary>
        public DateTime? FechaFinVigencia { get; set; }



    
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
