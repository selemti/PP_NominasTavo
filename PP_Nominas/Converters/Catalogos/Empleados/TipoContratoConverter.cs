using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados;

public static class TipoContratoConverter
{
    public static TipoContratoDto ToDto(TipoContrato model)
    {
        return new TipoContratoDto
        {
            Id = model.Id,
            NombreContrato = model.NombreContrato,
            DescripcionContrato = model.DescripcionContrato,
            ClaveSat = model.ClaveSat,
            Activo = model.Activo,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static TipoContrato FromDto(TipoContratoDto dto)
    {
        return new TipoContrato
        {
            Id = dto.Id,
            NombreContrato = dto.NombreContrato,
            DescripcionContrato = dto.DescripcionContrato,
            ClaveSat = dto.ClaveSat,
            Activo = dto.Activo,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
