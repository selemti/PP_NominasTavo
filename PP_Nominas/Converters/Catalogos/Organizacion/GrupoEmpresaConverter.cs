using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class GrupoEmpresaConverter
    {
        public static GrupoEmpresaDto ToDto(GrupoEmpresa model) => new GrupoEmpresaDto
        {
            Id = model.Id,
            Clave = model.Clave,
            Nombre = model.Nombre,
            Rfc = model.Rfc,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };

        public static GrupoEmpresa ToModel(GrupoEmpresaDto dto) => new GrupoEmpresa
        {
            Id = dto.Id,
            Clave = dto.Clave,
            Nombre = dto.Nombre,
            Rfc = dto.Rfc,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
