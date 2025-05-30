// Dtos/Catalogos/Nomina/FiniquitoLiquidacionDto.cs
using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class FiniquitoLiquidacionDto
    {
        public string EmpleadoId { get; set; } = string.Empty;
        public DateTime FechaFiniquito { get; set; } = DateTime.MinValue;
        public decimal IsrCalculado { get; set; }
        public decimal TotalFiniquito { get; set; }
        public List<ConceptoFiniquitoDto> Conceptos { get; set; } = new();
    public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
    public string UsuarioUltimaModificacion { get; set; } = string.Empty;
}
}