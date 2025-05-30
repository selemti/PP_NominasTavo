using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;
using PP_Nominas.Models.Catalogos.Shared;
using System;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class PeriodoNominaConverter
    {
        public static PeriodoNominaDto ToDto(PeriodoNomina model)
        {
            return new PeriodoNominaDto
            {
                Id = model.Id ?? string.Empty,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                TipoNomina = model.TipoNomina?.ToString() ?? string.Empty,
                TipoPeriodoId = model.TipoPeriodoId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static PeriodoNomina ToModel(PeriodoNominaDto dto)
        {
            return new PeriodoNomina
            {
                Id = dto.Id ?? string.Empty,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                TipoNomina = Enum.TryParse<TipoNominaEnum>(dto.TipoNomina, out var tipo) ? tipo : null,
                TipoPeriodoId = dto.TipoPeriodoId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
