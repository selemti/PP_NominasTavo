using PP_Nominas.Models.Catalogos.Seguridad;
using PP_Nominas.Dtos.Catalogos.Seguridad;

namespace PP_Nominas.Converters.Catalogos.Seguridad
{
    public static class UsuarioConverter
    {
        public static UsuarioDto ToDto(Usuario model)
        {
            return new UsuarioDto
            {
                Id = model.Id ?? string.Empty,
                NombreUsuario = model.NombreUsuario ?? string.Empty,
                CorreoElectronico = model.CorreoElectronico ?? string.Empty,
                PerfilId = model.PerfilId ?? string.Empty,
                EstatusUsuario = model.EstatusUsuario,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Usuario ToModel(UsuarioDto dto)
        {
            return new Usuario
            {
                Id = dto.Id ?? string.Empty,
                NombreUsuario = dto.NombreUsuario ?? string.Empty,
                CorreoElectronico = dto.CorreoElectronico ?? string.Empty,
                PerfilId = dto.PerfilId ?? string.Empty,
                EstatusUsuario = dto.EstatusUsuario,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
