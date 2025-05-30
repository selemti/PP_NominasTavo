using System.Linq;
using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class FiniquitoLiquidacionConverter
    {
        public static FiniquitoLiquidacionDto ToDto(FiniquitoLiquidacion model)
        {
            return new FiniquitoLiquidacionDto
            {
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                FechaFiniquito = model.FechaFiniquito,
                IsrCalculado = model.IsrCalculado,
                TotalFiniquito = model.TotalFiniquito,
                Conceptos = model.Conceptos.Select(ConceptoFiniquitoConverter.ToDto).ToList(),
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static FiniquitoLiquidacion ToModel(FiniquitoLiquidacionDto dto)
        {
            return new FiniquitoLiquidacion
            {
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                FechaFiniquito = dto.FechaFiniquito,
                IsrCalculado = dto.IsrCalculado,
                TotalFiniquito = dto.TotalFiniquito,
                Conceptos = dto.Conceptos.Select(ConceptoFiniquitoConverter.ToModel).ToList(),
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}

