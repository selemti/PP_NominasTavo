using PP_Nominas.Models.Catalogos.Prenomina;
using PP_Nominas.Dtos.Catalogos.Prenomina;

namespace PP_Nominas.Converters.Catalogos.Prenomina
{
    public static class ControlCierrePrenominaConverter
    {
        public static ControlCierrePrenominaDto ToDto(ControlCierrePrenomina model)
        {
            return new ControlCierrePrenominaDto
            {
                Id = model.Id ?? string.Empty,
                PeriodoNominaId = model.PeriodoNominaId ?? string.Empty,
                FechaCierre = model.FechaCierre,
                UsuarioCierreId = model.UsuarioCierreId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ControlCierrePrenomina ToModel(ControlCierrePrenominaDto dto)
        {
            return new ControlCierrePrenomina
            {
                Id = dto.Id ?? string.Empty,
                PeriodoNominaId = dto.PeriodoNominaId ?? string.Empty,
                FechaCierre = dto.FechaCierre,
                UsuarioCierreId = dto.UsuarioCierreId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
