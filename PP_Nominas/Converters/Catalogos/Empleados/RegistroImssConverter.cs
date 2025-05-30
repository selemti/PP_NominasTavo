using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class RegistroImssConverter
    {
        public static RegistroImssDto ToDto(RegistroImss model)
        {
            return new RegistroImssDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                Nss = model.Nss ?? string.Empty,
                FechaAlta = model.FechaAlta,
                FechaBaja = model.FechaBaja,
                Movimiento = model.Movimiento ?? string.Empty,
                Fecha = model.Fecha,
                Comentarios = model.Comentarios ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static RegistroImss ToModel(RegistroImssDto dto)
        {
            return new RegistroImss
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                Nss = dto.Nss ?? string.Empty,
                FechaAlta = dto.FechaAlta,
                FechaBaja = dto.FechaBaja,
                Movimiento = dto.Movimiento ?? string.Empty,
                Fecha = dto.Fecha,
                Comentarios = dto.Comentarios ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
