using System;

namespace PP_Nominas.Dtos.Catalogos.Compensaciones
{
    public class FondoAhorroDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public decimal? SaldoActual { get; set; }
        public decimal? PorcentajeAportacion { get; set; }
        public bool? Vigente { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
