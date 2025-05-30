using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class HistorialUbicacionEmpleadoConverter
    {
        public static HistorialUbicacionEmpleadoDto ToDto(HistorialUbicacionEmpleado model)
        {
            return new HistorialUbicacionEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                UbicacionId = model.UbicacionId ?? string.Empty,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                Observaciones = model.Observaciones ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static HistorialUbicacionEmpleado ToModel(HistorialUbicacionEmpleadoDto dto)
        {
            return new HistorialUbicacionEmpleado
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                UbicacionId = dto.UbicacionId ?? string.Empty,
                FechaInicio = dto.FechaInicio ?? DateTime.MinValue,
                FechaFin = dto.FechaFin,
                Observaciones = dto.Observaciones ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
