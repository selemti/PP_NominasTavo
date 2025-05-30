using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia
{
    public static class HorarioExcepcionConverter
    {
        public static HorarioExcepcionDto ToDto(HorarioExcepcion model) => new()
        {
            Id = model.Id ?? string.Empty,
            EmpleadoId = model.EmpleadoId ?? string.Empty,
            FechaInicio = model.FechaInicio,
            FechaFin = model.FechaFin,
            TurnoEspecialId = model.TurnoEspecialId ?? string.Empty,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
        };

        public static HorarioExcepcion FromDto(HorarioExcepcionDto dto) => new()
        {
            Id = dto.Id ?? string.Empty,
            EmpleadoId = dto.EmpleadoId ?? string.Empty,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin,
            TurnoEspecialId = dto.TurnoEspecialId ?? string.Empty,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
        };
    }
}
