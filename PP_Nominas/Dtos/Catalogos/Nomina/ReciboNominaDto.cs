using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class ReciboNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty; // Relación con el Empleado
        public string PeriodoNominaId { get; set; } = string.Empty; // Periodo de Nómina
        public double HorasExtrasTrabajadas { get; set; } // Horas extras trabajadas
        public double HorasExtrasAutorizadas { get; set; } // Horas extras autorizadas
        public decimal TotalPercepciones { get; set; } // Total de percepciones calculadas
        public decimal TotalDeducciones { get; set; } // Total de deducciones aplicadas
        public decimal TotalNeto { get; set; } // Total neto a pagar
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}