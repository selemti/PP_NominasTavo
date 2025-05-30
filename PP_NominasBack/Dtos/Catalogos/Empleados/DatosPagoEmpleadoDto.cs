using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    /// <summary>
    /// Representa la clase DatosPagoEmpleadoDto.
    /// </summary>
    public class DatosPagoEmpleadoDto
    {
        [Display(Name = "ID único del método de pago")]
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; }

        [Display(Name = "Banco de dispersión")]
        /// <summary>
        /// Obtiene o establece BancoId.
        /// </summary>
        public string? BancoId { get; set; }

        [Display(Name = "Número de cuenta bancaria")]
        /// <summary>
        /// Obtiene o establece CuentaBancaria.
        /// </summary>
        public string? CuentaBancaria { get; set; }

        [Display(Name = "Forma de pago")]
        
        /// <summary>
        /// Obtiene o establece FormaPago.
        /// </summary>
        public int? FormaPago { get; set; }

        [Display(Name = "¿Es la forma de pago actual?")]
        
        /// <summary>
        /// Obtiene o establece Vigente.
        /// </summary>
        public bool? Vigente { get; set; }

        [Display(Name = "Inicio de vigencia")]
        
        /// <summary>
        /// Obtiene o establece FechaInicio.
        /// </summary>
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "Fin de vigencia (nullable)")]
        
        /// <summary>
        /// Obtiene o establece FechaFin.
        /// </summary>
        public DateTime? FechaFin { get; set; }



    
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
