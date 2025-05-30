using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class PuestoConverter
    {
        public static PuestoDto ToDto(Puesto model) => new PuestoDto
        {
            Id = model.Id,
            NivelPuesto = model.NivelPuesto,
            FechaUltimaModificacion = model.FechaUltimaModificacion,
            UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
        };

        public static Puesto ToModel(PuestoDto dto) => new Puesto
        {
            Id = dto.Id,
            NivelPuesto = dto.NivelPuesto,
            FechaUltimaModificacion = dto.FechaUltimaModificacion,
            UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
        };
    }
}
