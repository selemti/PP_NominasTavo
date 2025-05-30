using System;
using System.Linq;
using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class ConfiguracionNominaConverter
    {
        public static ConfiguracionNominaDto ToDto(ConfiguracionNomina model)
        {
            return new ConfiguracionNominaDto
            {
                Id = model.Id ?? string.Empty,
                GrupoEmpresaId = model.GrupoEmpresaId ?? string.Empty,
                TipoNomina = model.TipoNomina?.ToString() ?? string.Empty,
                DiasPago = model.DiasPago.ToList(),
                CentroTrabajoId = model.CentroTrabajoId ?? string.Empty
            };
        }

        public static ConfiguracionNomina ToModel(ConfiguracionNominaDto dto)
        {
            return new ConfiguracionNomina
            {
                Id = dto.Id ?? string.Empty,
                GrupoEmpresaId = dto.GrupoEmpresaId ?? string.Empty,
                TipoNomina = Enum.TryParse<TipoNominaEnum>(dto.TipoNomina, out var tipo) ? tipo : null,
                DiasPago = dto.DiasPago.ToList(),
                CentroTrabajoId = dto.CentroTrabajoId ?? string.Empty
            };
        }
    }
}
