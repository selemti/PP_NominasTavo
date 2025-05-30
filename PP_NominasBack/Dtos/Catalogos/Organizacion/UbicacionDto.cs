using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    /// <summary>
    /// Representa la clase UbicacionDto.
    /// </summary>
    public class UbicacionDto
    {
        [Display(Name = "ID de la ubicación")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre de la ubicación")]
        
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }

        [Display(Name = "Coordenada geográfica")]
        
        /// <summary>
        /// Obtiene o establece Latitud.
        /// </summary>
        public decimal? Latitud { get; set; }

        [Display(Name = "Coordenada geográfica")]
        
        /// <summary>
        /// Obtiene o establece Longitud.
        /// </summary>
        public decimal? Longitud { get; set; }

        [Display(Name = "Radio permitido en metros")]
        
        /// <summary>
        /// Obtiene o establece Radio.
        /// </summary>
        public decimal? Radio { get; set; }

        [Display(Name = "Tipo (1=Polígono, 2=Radio)")]
        
        /// <summary>
        /// Obtiene o establece TipoUbicacion.
        /// </summary>
        public int? TipoUbicacion { get; set; }



    
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
