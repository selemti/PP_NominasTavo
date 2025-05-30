using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class RegistroPatronalConverter
    {
        public static RegistroPatronalDto ToDto(RegistroPatronal model)
        {
            return new RegistroPatronalDto
            {
                Id = model.Id,
                Rfc = model.Rfc,
                NumeroRegistro = model.NumeroRegistro,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static RegistroPatronal ToModel(RegistroPatronalDto dto)
        {
            return new RegistroPatronal
            {
                Id = dto.Id,
                Rfc = dto.Rfc,
                NumeroRegistro = dto.NumeroRegistro,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
