using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class HistorialRegistroImssConverter
    {
        public static HistorialRegistroImssDto ToDto(HistorialRegistroImss model)
        {
            return new HistorialRegistroImssDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                Nss = model.Nss ?? string.Empty,
                RegistroPatronalId = model.RegistroPatronalId ?? string.Empty,
                FechaAlta = model.FechaAlta,
                FechaBaja = model.FechaBaja,
                TipoMovimiento = model.TipoMovimiento ?? string.Empty,
                FechaMovimiento = model.FechaMovimiento,
                Comentarios = model.Comentarios ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static HistorialRegistroImss ToModel(HistorialRegistroImssDto dto)
        {
            return new HistorialRegistroImss
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                Nss = dto.Nss ?? string.Empty,
                RegistroPatronalId = dto.RegistroPatronalId ?? string.Empty,
                FechaAlta = dto.FechaAlta,
                FechaBaja = dto.FechaBaja,
                TipoMovimiento = dto.TipoMovimiento ?? string.Empty,
                FechaMovimiento = dto.FechaMovimiento,
                Comentarios = dto.Comentarios ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
