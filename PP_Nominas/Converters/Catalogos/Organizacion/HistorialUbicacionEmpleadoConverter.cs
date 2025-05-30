using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Helpers;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Organizacion;

public static class HistorialUbicacionEmpleadoConverter
{
    public static HistorialUbicacionEmpleadoDto ToDto(HistorialUbicacionEmpleado model)
    {
        return new HistorialUbicacionEmpleadoDto
        {
            UbicacionId = model.UbicacionId,
            FechaInicio = model.FechaInicio,
            FechaFin = model.FechaFin,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion,
        };
    }

    public static HistorialUbicacionEmpleado FromDto(HistorialUbicacionEmpleadoDto dto)
    {
        return new HistorialUbicacionEmpleado
        {
            UbicacionId = dto.UbicacionId,
            FechaInicio = dto.FechaInicio ?? DateTime.MinValue,
            FechaFin = dto.FechaFin,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
        };
    }
}
