using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia
{
    public static class HorarioConverter
    {
        public static HorarioDto ToDto(Horario model) => new()
        {
            Id = model.Id ?? string.Empty,
            TipoHorario = model.TipoHorario,
            Codigo = model.Codigo ?? string.Empty,
            Nombre = model.Nombre ?? string.Empty,
            Descripcion = model.Descripcion ?? string.Empty,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
        };

        public static Horario FromDto(HorarioDto dto) => new()
        {
            Id = dto.Id ?? string.Empty,
            TipoHorario = dto.TipoHorario,
            Codigo = dto.Codigo ?? string.Empty,
            Nombre = dto.Nombre ?? string.Empty,
            Descripcion = dto.Descripcion ?? string.Empty,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
        };
    }
}
