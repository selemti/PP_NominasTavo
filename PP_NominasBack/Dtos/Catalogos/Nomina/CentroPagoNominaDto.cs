using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase CentroPagoNominaDto.
    /// </summary>
    public class CentroPagoNominaDto
    {
        [Display(Name = "ID del centro de pago")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Nombre del centro de pago")]
        
        /// <summary>
        /// Obtiene o establece NombreCentroPago.
        /// </summary>
        public string? NombreCentroPago { get; set; }

        [Display(Name = "Fecha de corte quincena 1")]
        
        /// <summary>
        /// Obtiene o establece FechaCorteQuincena1.
        /// </summary>
        public int? FechaCorteQuincena1 { get; set; }

        [Display(Name = "Fecha de corte quincena 2")]
        
        /// <summary>
        /// Obtiene o establece FechaCorteQuincena2.
        /// </summary>
        public int? FechaCorteQuincena2 { get; set; }

        [Display(Name = "FechaPagoQuincena1")]
        
        /// <summary>
        /// Obtiene o establece FechaPagoQuincena1.
        /// </summary>
        public int? FechaPagoQuincena1 { get; set; }

        [Display(Name = "FechaPagoQuincena2")]
        
        /// <summary>
        /// Obtiene o establece FechaPagoQuincena2.
        /// </summary>
        public int? FechaPagoQuincena2 { get; set; }



    
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
