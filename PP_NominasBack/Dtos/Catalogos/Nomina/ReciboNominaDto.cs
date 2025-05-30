
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    /// <summary>
    /// Representa la clase ReciboNominaDto.
    /// </summary>
    public class ReciboNominaDto
    {
        [Display(Name = "ID de Recibo de Nómina")]
        
        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        public string? Id { get; set; }

        [Display(Name = "EmpleadoId")]
        
        /// <summary>
        /// Obtiene o establece EmpleadoId.
        /// </summary>
        public string? EmpleadoId { get; set; } // Relación con el Empleado

        [Display(Name = "Periodo de Nómina")]
        
        /// <summary>
        /// Obtiene o establece PeriodoNominaId.
        /// </summary>
        public string? PeriodoNominaId { get; set; } // Periodo de Nómina

        [Display(Name = "Horas Extras Trabajadas")]
        
        /// <summary>
        /// Obtiene o establece HorasExtrasTrabajadas.
        /// </summary>
        public double HorasExtrasTrabajadas { get; set; } // Horas extras trabajadas

        [Display(Name = "Horas Extras Autorizadas")]
        
        /// <summary>
        /// Obtiene o establece HorasExtrasAutorizadas.
        /// </summary>
        public double HorasExtrasAutorizadas { get; set; } // Horas extras autorizadas

        [Display(Name = "Total de Percepciones")]
        /// <summary>
        /// Obtiene o establece TotalPercepciones.
        /// </summary>
        public decimal TotalPercepciones { get; set; } // Total de percepciones calculadas

        [Display(Name = "Total de Deducciones")]
        /// <summary>
        /// Obtiene o establece TotalDeducciones.
        /// </summary>
        public decimal TotalDeducciones { get; set; } // Total de deducciones aplicadas

        [Display(Name = "Total Neto")]
        /// <summary>
        /// Obtiene o establece TotalNeto.
        /// </summary>
        public decimal TotalNeto { get; set; } // Total neto a pagar

    
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
