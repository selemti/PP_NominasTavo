// DTO
using System;

namespace PP_Nominas.Dtos.Catalogos.Fiscal
{
    public class TablaIsrDto
    {
        public string Id { get; set; } = string.Empty;
        public decimal? LimiteInferior { get; set; }
        public decimal? LimiteSuperior { get; set; }
        public decimal? CuotaFija { get; set; }
        public decimal? PorcentajeExcedente { get; set; }
        public int? Periodo { get; set; }
        public int? EjercicioFiscal { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
