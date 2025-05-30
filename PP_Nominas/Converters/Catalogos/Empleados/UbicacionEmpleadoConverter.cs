using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class UbicacionEmpleadoConverter
    {
        public static UbicacionEmpleadoDto ToDto(UbicacionEmpleado model)
        {
            return new UbicacionEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                Nombre = model.Nombre ?? string.Empty,
                Descripcion = model.Descripcion ?? string.Empty,
                Activa = model.Activa,
                FechaAsignacion = model.FechaAsignacion,
                SucursalId = model.SucursalId ?? string.Empty,
                NombreSucursal = model.NombreSucursal ?? string.Empty,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static UbicacionEmpleado ToModel(UbicacionEmpleadoDto dto)
        {
            return new UbicacionEmpleado
            {
                Id = dto.Id ?? string.Empty,
                Nombre = dto.Nombre ?? string.Empty,
                Descripcion = dto.Descripcion ?? string.Empty,
                Activa = dto.Activa,
                FechaAsignacion = dto.FechaAsignacion,
                SucursalId = dto.SucursalId ?? string.Empty,
                NombreSucursal = dto.NombreSucursal ?? string.Empty,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
