using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class ArchivoEmpleadoConverter
    {
        public static ArchivoEmpleadoDto ToDto(ArchivoEmpleado model)
        {
            return new ArchivoEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                TipoArchivo = model.TipoArchivo,
                UrlArchivo = model.UrlArchivo ?? string.Empty,
                FechaCarga = model.FechaCarga,
                Vigente = model.Vigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ArchivoEmpleado ToModel(ArchivoEmpleadoDto dto)
        {
            return new ArchivoEmpleado
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                TipoArchivo = dto.TipoArchivo,
                UrlArchivo = dto.UrlArchivo ?? string.Empty,
                FechaCarga = dto.FechaCarga,
                Vigente = dto.Vigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
