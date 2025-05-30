using PP_Nominas.Models.Catalogos.Deducciones;
using PP_Nominas.Dtos.Catalogos.Deducciones;

public static class CatalogoDeduccionesConverter
{
    public static CatalogoDeduccionesDto ToDto(CatalogoDeducciones model)
    {
        if (model == null) return null!;

        return new CatalogoDeduccionesDto
        {
            Id = model.Id,
            TipoDeduccion = model.TipoDeduccion,
            NombreDeduccion = model.NombreDeduccion,
            DescripcionDeduccion = model.DescripcionDeduccion,
            AplicaEmpresaId = model.AplicaEmpresaId,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion,
        };
    }

    public static CatalogoDeducciones ToModel(CatalogoDeduccionesDto dto)
    {
        if (dto == null) return null!;

        var model = new CatalogoDeducciones
        {
            Id = dto.Id,
            TipoDeduccion = dto.TipoDeduccion,
            NombreDeduccion = dto.NombreDeduccion,
            DescripcionDeduccion = dto.DescripcionDeduccion,
            AplicaEmpresaId = dto.AplicaEmpresaId,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
        };

        return model;
    }
}
