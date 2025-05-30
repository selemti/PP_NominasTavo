using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase ChecadaRemotaDto.
    /// </summary>
    public class ChecadaRemotaDto
    {
        [Display(Name = "Id")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "EmpleadoId")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "FechaHora")]
        
        /// <summary>
        /// Obtiene o establece FechaHora.
        /// </summary>
        public DateTime FechaHora { get; set; }

        [Display(Name = "TipoEvento")]
        
        /// <summary>
        /// Obtiene o establece TipoEvento.
        /// </summary>
        public int TipoEvento { get; set; }

        [Display(Name = "Latitud")]
        
        /// <summary>
        /// Obtiene o establece Latitud.
        /// </summary>
        public decimal Latitud { get; set; }

        [Display(Name = "Longitud")]
        
        /// <summary>
        /// Obtiene o establece Longitud.
        /// </summary>
        public decimal Longitud { get; set; }

        [Display(Name = "UbicacionId")]
        
        /// <summary>
        /// Obtiene o establece UbicacionId.
        /// </summary>
        public string? UbicacionId { get; set; }

        [Display(Name = "FotoAdjunta")]
        
        /// <summary>
        /// Obtiene o establece FotoAdjunta.
        /// </summary>
        public string? FotoAdjunta { get; set; }



    
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
