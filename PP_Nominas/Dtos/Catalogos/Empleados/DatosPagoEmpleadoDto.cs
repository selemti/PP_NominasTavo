using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class DatosPagoEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string BancoId { get; set; } = string.Empty;
        public string CuentaBancaria { get; set; } = string.Empty;
        public int? FormaPago { get; set; }
        public bool? Vigente { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Banco { get; set; } = string.Empty;
        public string Clabe { get; set; } = string.Empty;
        public string NumeroCuenta { get; set; } = string.Empty;
        public string UsoCfdi { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
