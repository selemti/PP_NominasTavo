using PP_Nominas.Models.Catalogos.Prenomina;
using PP_Nominas.Dtos.Catalogos.Prenomina;

namespace PP_Nominas.Converters.Catalogos.Prenomina
{
    public static class HistorialValidacionConverter
    {
        public static HistorialValidacionDto ToDto(HistorialValidacion model)
        {
            return new HistorialValidacionDto
            {
                Id = model.Id ?? string.Empty,
                PeriodoNominaId = model.PeriodoNominaId ?? string.Empty,
                UsuarioValidadorId = model.UsuarioValidadorId ?? string.Empty,
                Resultado = model.Resultado ?? string.Empty,
                FechaValidacion = model.FechaValidacion,
                Observaciones = model.Observaciones ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static HistorialValidacion ToModel(HistorialValidacionDto dto)
        {
            return new HistorialValidacion
            {
                Id = dto.Id ?? string.Empty,
                PeriodoNominaId = dto.PeriodoNominaId ?? string.Empty,
                UsuarioValidadorId = dto.UsuarioValidadorId ?? string.Empty,
                Resultado = dto.Resultado ?? string.Empty,
                FechaValidacion = dto.FechaValidacion,
                Observaciones = dto.Observaciones ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
