using PP_Nominas.Dtos.Catalogos.Compensaciones;
using PP_Nominas.Models.Catalogos.Compensaciones;

public static class EmpleadoCompensacionConverter
{
    public static EmpleadoCompensacionDto ToDto(EmpleadoCompensacion model)
    {
        if (model == null) return null!;

        return new EmpleadoCompensacionDto
        {
            Id = model.Id,
            EmpleadoId = model.EmpleadoId,
            CompensacionId = model.CompensacionId,
            Valor = model.Valor,
            TipoAsignacion = model.TipoAsignacion,
            Formula = model.Formula,
            Periodicidad = model.Periodicidad,
            FechaInicio = model.FechaInicio,
            FechaFin = model.FechaFin,
            Vigente = model.Vigente,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static EmpleadoCompensacion ToModel(EmpleadoCompensacionDto dto)
    {
        if (dto == null) return null!;

        return new EmpleadoCompensacion
        {
            Id = dto.Id,
            EmpleadoId = dto.EmpleadoId,
            CompensacionId = dto.CompensacionId,
            Valor = dto.Valor,
            TipoAsignacion = dto.TipoAsignacion,
            Formula = dto.Formula,
            Periodicidad = dto.Periodicidad,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin,
            Vigente = dto.Vigente,  // Asignar directamente la colección
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }

}
