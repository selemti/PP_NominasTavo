using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase PoliticaDto.
    /// </summary>
    public class PoliticaDto
    {
        [Display(Name = "ID de la política")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre de la política")]
        
        /// <summary>
        /// Obtiene o establece NombrePolitica.
        /// </summary>
        public string? NombrePolitica { get; set; }

        [Display(Name = "DescripcionPolitica")]
        
        /// <summary>
        /// Obtiene o establece DescripcionPolitica.
        /// </summary>
        public string? DescripcionPolitica { get; set; }

        [Display(Name = "Número de versión")]
        
        /// <summary>
        /// Obtiene o establece VersionPolitica.
        /// </summary>
        public string? VersionPolitica { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        
        /// <summary>
        /// Obtiene o establece FechaInicioVigencia.
        /// </summary>
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha de fin de vigencia (opcional)")]
        
        /// <summary>
        /// Obtiene o establece FechaFinVigencia.
        /// </summary>
        public string? FechaFinVigencia { get; set; }



    
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
