using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class CentroPagoNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string NombreCentroPago { get; set; } = string.Empty;
        public int? FechaCorteQuincena1 { get; set; }
        public int? FechaCorteQuincena2 { get; set; }
        public int? FechaPagoQuincena1 { get; set; }
        public int? FechaPagoQuincena2 { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
