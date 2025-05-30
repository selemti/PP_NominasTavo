using PP_Nominas.Models.Catalogos.Vacaciones;
using PP_Nominas.Dtos.Catalogos.Vacaciones;

namespace PP_Nominas.Converters.Catalogos.Vacaciones
{
    public static class VacacionConverter
    {
        public static VacacionDto ToDto(Vacacion model)
        {
            return new VacacionDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                DiasProgramados = model.DiasProgramados,
                DiasGozados = model.DiasGozados,
                PeriodoVacacionalId = model.PeriodoVacacionalId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Vacacion ToModel(VacacionDto dto)
        {
            return new Vacacion
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                DiasProgramados = dto.DiasProgramados,
                DiasGozados = dto.DiasGozados,
                PeriodoVacacionalId = dto.PeriodoVacacionalId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
