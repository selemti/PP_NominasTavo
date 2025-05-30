// DTO
using System;

namespace PP_Nominas.Dtos.Catalogos.Fiscal
{
    public class TablaInfonavitDto
    {
        public string Id { get; set; } = string.Empty;
        public int? TipoDescuento { get; set; }
        public decimal? ValorDescuento { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int? EjercicioFiscal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
