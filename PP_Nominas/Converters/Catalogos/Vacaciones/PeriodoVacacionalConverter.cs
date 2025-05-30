using PP_Nominas.Models.Catalogos.Vacaciones;
using PP_Nominas.Dtos.Catalogos.Vacaciones;

namespace PP_Nominas.Converters.Catalogos.Vacaciones
{
    public static class PeriodoVacacionalConverter
    {
        public static PeriodoVacacionalDto ToDto(PeriodoVacacional model)
        {
            return new PeriodoVacacionalDto
            {
                Id = model.Id ?? string.Empty,
                Anio = model.Anio,
                DiasAsignados = model.DiasAsignados,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static PeriodoVacacional ToModel(PeriodoVacacionalDto dto)
        {
            return new PeriodoVacacional
            {
                Id = dto.Id ?? string.Empty,
                Anio = dto.Anio,
                DiasAsignados = dto.DiasAsignados,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
