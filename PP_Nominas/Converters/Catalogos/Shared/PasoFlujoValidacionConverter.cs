using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class PasoFlujoValidacionConverter
    {
        public static PasoFlujoValidacionDto ToDto(PasoFlujoValidacion model)
        {
            return new PasoFlujoValidacionDto
            {
                Id = model.Id,
                FlujoValidacionId = model.FlujoValidacionId,
                Orden = model.Orden,
                NombrePaso = model.NombrePaso,
                TipoResponsable = model.TipoResponsable.ToString(),
                UsuarioId = model.UsuarioId,
                PerfilId = model.PerfilId,
                Estado = model.Estado.ToString(),
                Comentarios = model.Comentarios,
                FechaValidacion = model.FechaValidacion,
                IpValidacion = model.IpValidacion,
                Dispositivo = model.Dispositivo
            };
        }

        public static PasoFlujoValidacion ToModel(PasoFlujoValidacionDto dto)
        {
            return new PasoFlujoValidacion
            {
                Id = dto.Id,
                FlujoValidacionId = dto.FlujoValidacionId,
                Orden = dto.Orden,
                NombrePaso = dto.NombrePaso,
                TipoResponsable = Enum.TryParse<TipoResponsableEnum>(dto.TipoResponsable, out var tipo) ? tipo : TipoResponsableEnum.Sistema,
                UsuarioId = dto.UsuarioId,
                PerfilId = dto.PerfilId,
                Estado = Enum.TryParse<EstadoPasoFlujoEnum>(dto.Estado, out var estado) ? estado : EstadoPasoFlujoEnum.Pendiente,
                Comentarios = dto.Comentarios,
                FechaValidacion = dto.FechaValidacion,
                IpValidacion = dto.IpValidacion,
                Dispositivo = dto.Dispositivo
            };
        }
    }
}
