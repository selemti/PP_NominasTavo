using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;
using PP_Nominas.Models.Catalogos.Shared;
using System;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class ResponsableNominaConverter
    {
        public static ResponsableNominaDto ToDto(ResponsableNomina model)
        {
            return new ResponsableNominaDto
            {
                Id = model.Id ?? string.Empty,
                UsuarioId = model.UsuarioId ?? string.Empty,
                TipoResponsabilidad = model.TipoResponsabilidad?.ToString() ?? string.Empty,
                CentroPagoNominaId = model.CentroPagoNominaId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ResponsableNomina ToModel(ResponsableNominaDto dto)
        {
            return new ResponsableNomina
            {
                Id = dto.Id ?? string.Empty,
                UsuarioId = dto.UsuarioId ?? string.Empty,
                TipoResponsabilidad = Enum.TryParse<TipoResponsabilidadEnum>(dto.TipoResponsabilidad, out var tipo) ? tipo : null,
                CentroPagoNominaId = dto.CentroPagoNominaId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
