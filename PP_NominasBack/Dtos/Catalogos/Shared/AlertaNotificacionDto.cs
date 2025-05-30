using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    /// <summary>
    /// Representa la clase AlertaNotificacionDto.
    /// </summary>
    public class AlertaNotificacionDto
    {
        [Display(Name = "ID único de la alerta")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Evento que genera la alerta")]
        
        /// <summary>
        /// Obtiene o establece EventoDisparador.
        /// </summary>
        public string? EventoDisparador { get; set; }

        [Display(Name = "Descripción de la alerta")]
        
        /// <summary>
        /// Obtiene o establece DescripcionAlerta.
        /// </summary>
        public string? DescripcionAlerta { get; set; }

        [Display(Name = "(0 = Única, 1 = Recurrente diaria, 2 = Recurrente semanal)")]
        
        /// <summary>
        /// Obtiene o establece TipoPeriodicidad.
        /// </summary>
        public int? TipoPeriodicidad { get; set; }

        [Display(Name = "(0 = Correo, 1 = WhatsApp, 2 = Sistema Interno)")]
        
        /// <summary>
        /// Obtiene o establece MedioEnvio.
        /// </summary>
        public int? MedioEnvio { get; set; }

        [Display(Name = "Mensaje personalizado que se enviará")]
        
        /// <summary>
        /// Obtiene o establece PlantillaMensaje.
        /// </summary>
        public string? PlantillaMensaje { get; set; }

        [Display(Name = "Indica si la alerta está activa")]
        
        /// <summary>
        /// Obtiene o establece Activo.
        /// </summary>
        public bool? Activo { get; set; }



    
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
