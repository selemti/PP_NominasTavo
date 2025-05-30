using PP_Nominas.Models.Catalogos.Organizacion;
using PP_Nominas.Dtos.Catalogos.Organizacion;

namespace PP_Nominas.Converters.Catalogos.Organizacion
{
    public static class UbicacionConverter
    {
        public static UbicacionDto ToDto(Ubicacion model)
        {
            return new UbicacionDto
            {
                Id = model.Id ?? string.Empty,
                Nombre = model.Nombre ?? string.Empty,
                Latitud = model.Latitud,
                Longitud = model.Longitud,
                Radio = model.Radio,
                TipoUbicacion = model.TipoUbicacion,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Ubicacion ToModel(UbicacionDto dto)
        {
            return new Ubicacion
            {
                Id = dto.Id ?? string.Empty,
                Nombre = dto.Nombre ?? string.Empty,
                Latitud = dto.Latitud,
                Longitud = dto.Longitud,
                Radio = dto.Radio,
                TipoUbicacion = dto.TipoUbicacion,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
