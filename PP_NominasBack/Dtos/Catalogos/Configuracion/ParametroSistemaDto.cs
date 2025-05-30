using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase ParametroSistemaDto.
    /// </summary>
    public class ParametroSistemaDto
    {
        [Display(Name = "ID del parámetro")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Clave única del parámetro")]
        
        /// <summary>
        /// Obtiene o establece ClaveParametro.
        /// </summary>
        public string? ClaveParametro { get; set; }

        [Display(Name = "Valor configurado")]
        
        /// <summary>
        /// Obtiene o establece ValorParametro.
        /// </summary>
        public string? ValorParametro { get; set; }

        [Display(Name = "Descripción del parámetro")]
        
        /// <summary>
        /// Obtiene o establece DescripcionParametro.
        /// </summary>
        public string? DescripcionParametro { get; set; }



    
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
