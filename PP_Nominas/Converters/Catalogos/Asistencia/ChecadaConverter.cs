using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia;

public static class ChecadaConverter
{
    public static ChecadaDto ToDto(Checada model)
    {
        return new ChecadaDto
        {
            Id = model.Id,
            EmpleadoId = model.EmpleadoId,
            FechaHora = model.FechaHora,
            TipoEvento = model.TipoEvento,
            DispositivoId = model.DispositivoId,
            HorasTrabajadas = model.HorasTrabajadas,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static Checada FromDto(ChecadaDto dto)
    {
        return new Checada
        {
            Id = dto.Id,
            EmpleadoId = dto.EmpleadoId,
            FechaHora = dto.FechaHora,
            TipoEvento = dto.TipoEvento,
            DispositivoId = dto.DispositivoId,
            HorasTrabajadas = dto.HorasTrabajadas,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
