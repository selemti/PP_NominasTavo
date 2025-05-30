using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase LogsSincronizacionDto.
    /// </summary>
    public class LogsSincronizacionDto
    {
        [Display(Name = "ID del log de sincronización")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Dispositivo involucrado")]
        
        /// <summary>
        /// Obtiene o establece DispositivoId.
        /// </summary>
        public string? DispositivoId { get; set; }

        [Display(Name = "Fecha y hora del evento de sincronización")]
        
        /// <summary>
        /// Obtiene o establece FechaEvento.
        /// </summary>
        public DateTime? FechaEvento { get; set; }

        [Display(Name = "Mensaje del evento")]
        
        /// <summary>
        /// Obtiene o establece DescripcionLog.
        /// </summary>
        public string? DescripcionLog { get; set; }



    
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
