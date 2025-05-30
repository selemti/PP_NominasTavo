using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class CatalogoEntidadesConverter
    {
        public static CatalogoEntidadesDto ToDto(CatalogoEntidades model)
        {
            return new CatalogoEntidadesDto
            {
                Id = model.Id ?? string.Empty,
                EntityCode = model.EntityCode ?? string.Empty,
                NombreEntidad = model.NombreEntidad ?? string.Empty,
                ModuloRelacionado = model.ModuloRelacionado ?? string.Empty,
                DescripcionEntidad = model.DescripcionEntidad ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static CatalogoEntidades ToModel(CatalogoEntidadesDto dto)
        {
            return new CatalogoEntidades
            {
                Id = dto.Id ?? string.Empty,
                EntityCode = dto.EntityCode ?? string.Empty,
                NombreEntidad = dto.NombreEntidad ?? string.Empty,
                ModuloRelacionado = dto.ModuloRelacionado ?? string.Empty,
                DescripcionEntidad = dto.DescripcionEntidad ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
