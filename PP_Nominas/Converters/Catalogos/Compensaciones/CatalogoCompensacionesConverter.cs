using PP_Nominas.Models.Catalogos.Compensaciones;
using PP_Nominas.Dtos.Catalogos.Compensaciones;

public static class CatalogoCompensacionesConverter
{
    public static CatalogoCompensacionesDto ToDto(CatalogoCompensaciones model)
    {
        if (model == null) return null!;

        return new CatalogoCompensacionesDto
        {
            Id = model.Id,
            TipoCompensacion = model.TipoCompensacion,
            NombreCompensacion = model.NombreCompensacion,
            DescripcionCompensacion = model.DescripcionCompensacion,
            AplicaEmpresaId = model.AplicaEmpresaId,
            AplicaDivisionId = model.AplicaDivisionId,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };
    }

    public static CatalogoCompensaciones ToModel(CatalogoCompensacionesDto dto)
    {
        if (dto == null) return null!;

        return new CatalogoCompensaciones
        {
            Id = dto.Id,
            TipoCompensacion = dto.TipoCompensacion,
            NombreCompensacion = dto.NombreCompensacion,
            DescripcionCompensacion = dto.DescripcionCompensacion,
            AplicaEmpresaId = dto.AplicaEmpresaId,
            AplicaDivisionId = dto.AplicaDivisionId,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
