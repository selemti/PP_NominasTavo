using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase RangoToleranciaDto.
    /// </summary>
    public class RangoToleranciaDto
    {
        [Display(Name = "ID del rango")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Código del rango")]
        
        /// <summary>
        /// Obtiene o establece Codigo.
        /// </summary>
        public string? Codigo { get; set; }

        [Display(Name = "Nombre descriptivo")]
        
        /// <summary>
        /// Obtiene o establece Nombre.
        /// </summary>
        public string? Nombre { get; set; }

        [Display(Name = "Minutos desde que inicia el rango")]
        
        /// <summary>
        /// Obtiene o establece MinutosDesde.
        /// </summary>
        public int? MinutosDesde { get; set; }

        [Display(Name = "Minutos hasta donde termina el rango")]
        
        /// <summary>
        /// Obtiene o establece MinutosHasta.
        /// </summary>
        public int? MinutosHasta { get; set; }

        [Display(Name = "¿Aplica descuento? (true/false)")]
        
        /// <summary>
        /// Obtiene o establece Penalizacion.
        /// </summary>
        public bool? Penalizacion { get; set; }



    
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
