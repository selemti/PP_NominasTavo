using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class DetallePercepcionesDto
    {
        public string Id { get; set; } = string.Empty;
        public string ReciboNominaId { get; set; } = string.Empty;
        public string TipoCompensacionId { get; set; } = string.Empty;
        public decimal? Monto { get; set; }
        public int? TipoFiscalizacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}