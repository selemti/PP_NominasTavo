using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class DestinatarioAlertaConverter
    {
        public static DestinatarioAlertaDto ToDto(DestinatarioAlerta model)
        {
            return new DestinatarioAlertaDto
            {
                Id = model.Id,
                AlertaNotificacionId = model.AlertaNotificacionId,
                UsuarioId = model.UsuarioId,
                PerfilId = model.PerfilId,
                TipoDestinatario = model.TipoDestinatario.ToString(),
                Leido = model.Leido,
                FechaLectura = model.FechaLectura
            };
        }

        public static DestinatarioAlerta ToModel(DestinatarioAlertaDto dto)
        {
            return new DestinatarioAlerta
            {
                Id = dto.Id,
                AlertaNotificacionId = dto.AlertaNotificacionId,
                UsuarioId = dto.UsuarioId,
                PerfilId = dto.PerfilId,
                TipoDestinatario = Enum.TryParse<TipoDestinatarioEnum>(dto.TipoDestinatario, out var tipo) ? tipo : TipoDestinatarioEnum.Global,
                Leido = dto.Leido,
                FechaLectura = dto.FechaLectura
            };
        }
    }
}
