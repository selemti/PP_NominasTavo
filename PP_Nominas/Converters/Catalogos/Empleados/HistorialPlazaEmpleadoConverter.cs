using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados;

public static class HistorialPlazaEmpleadoConverter
{
    public static HistorialPlazaEmpleadoDto ToDto(HistorialPlazaEmpleado model)
    {
        return new HistorialPlazaEmpleadoDto
        {
            Id = model.Id ?? string.Empty,
            EmpleadoId = model.EmpleadoId,
            PlazaIdAnterior = model.PlazaIdAnterior,
            PlazaIdNueva = model.PlazaIdNueva,
            FechaCambio = model.FechaCambio,
            MotivoCambio = model.MotivoCambio,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static HistorialPlazaEmpleado FromDto(HistorialPlazaEmpleadoDto dto)
    {
        return new HistorialPlazaEmpleado
        {
            Id = dto.Id,
            EmpleadoId = dto.EmpleadoId,
            PlazaIdAnterior = dto.PlazaIdAnterior,
            PlazaIdNueva = dto.PlazaIdNueva,
            FechaCambio = dto.FechaCambio,
            MotivoCambio = dto.MotivoCambio,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
