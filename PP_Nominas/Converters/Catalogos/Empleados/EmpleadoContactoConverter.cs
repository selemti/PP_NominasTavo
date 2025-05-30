using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Empleados;

namespace PP_Nominas.Converters
{
    public static class EmpleadoContactoConverter
    {
        public static EmpleadoContactoDto ToDto(EmpleadoContacto modelo)
        {
            return new EmpleadoContactoDto
            {
                Id = modelo.Id ?? string.Empty,
                EmpleadoId = modelo.EmpleadoId ?? string.Empty,
                NombreContacto = modelo.NombreContacto ?? string.Empty,
                Parentesco = modelo.Parentesco,
                FechaUltimaModificacion = modelo.FechaUltimaModificacion,
                UsuarioUltimaModificacion = modelo.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static EmpleadoContacto ToModel(EmpleadoContactoDto dto)
        {
            return new EmpleadoContacto
            {
                Id = dto.Id,
                EmpleadoId = dto.EmpleadoId,
                NombreContacto = dto.NombreContacto,
                Parentesco = dto.Parentesco,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}