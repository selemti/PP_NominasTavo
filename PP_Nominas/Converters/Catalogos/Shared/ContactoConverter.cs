using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class ContactoConverter
    {
        public static ContactoDto ToDto(Contacto model)
        {
            return new ContactoDto
            {
                Id = model.Id ?? string.Empty,
                TipoEntidad = model.TipoEntidad ?? string.Empty,
                EntidadId = model.EntidadId ?? string.Empty,
                NombreContacto = model.NombreContacto ?? string.Empty,
                TelefonoContacto = model.TelefonoContacto ?? string.Empty,
                Parentesco = model.Parentesco ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Contacto ToModel(ContactoDto dto)
        {
            return new Contacto
            {
                Id = dto.Id ?? string.Empty,
                TipoEntidad = dto.TipoEntidad ?? string.Empty,
                EntidadId = dto.EntidadId ?? string.Empty,
                NombreContacto = dto.NombreContacto ?? string.Empty,
                TelefonoContacto = dto.TelefonoContacto ?? string.Empty,
                Parentesco = dto.Parentesco ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
