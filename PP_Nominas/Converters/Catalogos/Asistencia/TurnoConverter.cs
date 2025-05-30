using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia
{
    public static class TurnoConverter
    {
        public static TurnoDto ToDto(Turno model)
        {
            return new TurnoDto
            {
                Id = model.Id ?? string.Empty,
                NombreTurno = model.NombreTurno ?? string.Empty,
                HoraEntrada = model.HoraEntrada ?? string.Empty,
                HoraSalida = model.HoraSalida ?? string.Empty,
                TipoTurno = model.TipoTurno,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Turno ToModel(TurnoDto dto)
        {
            return new Turno
            {
                Id = dto.Id ?? string.Empty,
                NombreTurno = dto.NombreTurno ?? string.Empty,
                HoraEntrada = dto.HoraEntrada ?? string.Empty,
                HoraSalida = dto.HoraSalida ?? string.Empty,
                TipoTurno = dto.TipoTurno,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
