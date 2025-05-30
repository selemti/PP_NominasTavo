using PP_Nominas.Models.Catalogos.Seguridad;
using PP_Nominas.Dtos.Catalogos.Seguridad;

namespace PP_Nominas.Converters.Catalogos.Seguridad
{
    public static class PerfilConverter
    {
        public static PerfilDto ToDto(Perfil model)
        {
            return new PerfilDto
            {
                Id = model.Id ?? string.Empty,
                NombrePerfil = model.NombrePerfil ?? string.Empty,
                DescripcionPerfil = model.DescripcionPerfil ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Perfil ToModel(PerfilDto dto)
        {
            return new Perfil
            {
                Id = dto.Id ?? string.Empty,
                NombrePerfil = dto.NombrePerfil ?? string.Empty,
                DescripcionPerfil = dto.DescripcionPerfil ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
