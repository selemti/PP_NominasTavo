using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia;

public static class CalendarioLaboralConverter
{
    public static CalendarioLaboralDto ToDto(CalendarioLaboral model)
    {
        return new CalendarioLaboralDto
        {
            Id = model.Id,
            Fecha = model.Fecha,
            TipoDia = model.TipoDia,
            DescripcionEvento = model.DescripcionEvento,
            EmpresaId = model.EmpresaId,
            DivisionId = model.DivisionId,
            Vigente = model.Vigente,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static CalendarioLaboral FromDto(CalendarioLaboralDto dto)
    {
        return new CalendarioLaboral
        {
            Id = dto.Id,
            Fecha = dto.Fecha,
            TipoDia = dto.TipoDia,
            DescripcionEvento = dto.DescripcionEvento,
            EmpresaId = dto.EmpresaId,
            DivisionId = dto.DivisionId,
            Vigente = dto.Vigente,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
