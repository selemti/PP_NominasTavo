using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class CfdiNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string ReciboNominaId { get; set; } = string.Empty;
        public string Uuid { get; set; } = string.Empty;
        public string SelloDigital { get; set; } = string.Empty;
        public DateTime? FechaTimbre { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
