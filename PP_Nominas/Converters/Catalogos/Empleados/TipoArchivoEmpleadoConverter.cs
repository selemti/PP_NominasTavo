using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class TipoArchivoEmpleadoConverter
    {
        public static TipoArchivoEmpleadoDto ToDto(TipoArchivoEmpleado model)
        {
            return new TipoArchivoEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                Codigo = model.Codigo ?? string.Empty,
                Nombre = model.Nombre ?? string.Empty,
                Requerido = model.Requerido,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static TipoArchivoEmpleado ToModel(TipoArchivoEmpleadoDto dto)
        {
            return new TipoArchivoEmpleado
            {
                Id = dto.Id ?? string.Empty,
                Codigo = dto.Codigo ?? string.Empty,
                Nombre = dto.Nombre ?? string.Empty,
                Requerido = dto.Requerido,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
