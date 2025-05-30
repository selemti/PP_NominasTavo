// DTO
using System;

namespace PP_Nominas.Dtos.Catalogos.Fiscal
{
    public class TablaImssDto
    {
        public string Id { get; set; } = string.Empty;
        public string Concepto { get; set; } = string.Empty;
        public decimal? PorcentajePatronal { get; set; }
        public decimal? PorcentajeObrero { get; set; }
        public bool? SalarioMinimoAplica { get; set; }
        public int? EjercicioFiscal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
