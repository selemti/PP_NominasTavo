using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

public static class CompensacionOvertimeConverter
{
    public static CompensacionOvertimeDto ToDto(CompensacionOvertime model) => new()
    {
        Id = model.Id ?? string.Empty,
        Codigo = model.Codigo ?? string.Empty,
        Nombre = model.Nombre ?? string.Empty,
        Descripcion = model.Descripcion ?? string.Empty,
        FechaUltimaModificacion = model.FechaUltimaModificacion,
        UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
    };

    public static CompensacionOvertime FromDto(CompensacionOvertimeDto dto) => new()
    {
        Id = dto.Id ?? string.Empty,
        Codigo = dto.Codigo ?? string.Empty,
        Nombre = dto.Nombre ?? string.Empty,
        Descripcion = dto.Descripcion ?? string.Empty,
        FechaUltimaModificacion = dto.FechaUltimaModificacion,
        UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
    };
}
