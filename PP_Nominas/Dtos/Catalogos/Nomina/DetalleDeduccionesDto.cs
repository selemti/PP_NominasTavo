using System;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class DetalleDeduccionesDto
    {
        public string Id { get; set; } = string.Empty;
        public string ReciboNominaId { get; set; } = string.Empty;
        public string TipoDeduccionId { get; set; } = string.Empty;
        public decimal? Monto { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}