using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Compensaciones
{
    public class MovimientoFondoAhorroDto
    {
        public string Id { get; set; } = string.Empty;
        public string FondoAhorroId { get; set; } = string.Empty;
        public int? TipoMovimiento { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}