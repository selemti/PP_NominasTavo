using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia;

public static class ChecadaAgregadaConverter
{
    public static ChecadaAgregadaDto ToDto(ChecadaAgregada model)
    {
        return new ChecadaAgregadaDto
        {
            Id = model.Id,
            EmpleadoId = model.EmpleadoId,
            Fecha = model.Fecha,
            HoraEntrada = model.HoraEntrada,
            HoraSalida = model.HoraSalida,
            Observaciones = model.Observaciones,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static ChecadaAgregada FromDto(ChecadaAgregadaDto dto)
    {
        return new ChecadaAgregada
        {
            Id = dto.Id,
            EmpleadoId = dto.EmpleadoId,
            Fecha = dto.Fecha,
            HoraEntrada = dto.HoraEntrada,
            HoraSalida = dto.HoraSalida,
            Observaciones = dto.Observaciones,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
