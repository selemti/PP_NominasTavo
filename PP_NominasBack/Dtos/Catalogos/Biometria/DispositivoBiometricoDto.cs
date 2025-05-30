using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    /// <summary>
    /// Representa la clase DispositivoBiometricoDto.
    /// </summary>
    public class DispositivoBiometricoDto
    {
        [Display(Name = "ID del dispositivo biométrico")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Modelo del dispositivo")]
        
        /// <summary>
        /// Obtiene o establece Modelo.
        /// </summary>
        public string? Modelo { get; set; }

        [Display(Name = "Número de serie del dispositivo")]
        
        /// <summary>
        /// Obtiene o establece NumeroSerie.
        /// </summary>
        public string? NumeroSerie { get; set; }

        [Display(Name = "IP de red asignada")]
        
        /// <summary>
        /// Obtiene o establece IpAsignada.
        /// </summary>
        public string? IpAsignada { get; set; }

        [Display(Name = "Tipo (0 = Biométrico, 1 = Facial, 2 = Huella)")]
        
        /// <summary>
        /// Obtiene o establece TipoDispositivo.
        /// </summary>
        public int? TipoDispositivo { get; set; }



        [Display(Name = "Referencia al Centro de Trabajo")]
        
        /// <summary>
        /// Obtiene o establece CentroId.
        /// </summary>
        public string? CentroId { get; set; }

    
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
