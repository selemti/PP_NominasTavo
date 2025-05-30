using System.Linq;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class AlertaNotificacionConverter
    {
        public static AlertaNotificacionDto ToDto(AlertaNotificacion model)
        {
            return new AlertaNotificacionDto
            {
                Id = model.Id,
                EventoDisparador = model.EventoDisparador,
                DescripcionAlerta = model.DescripcionAlerta,
                TipoAlerta = model.TipoAlerta.ToString(),
                TipoPeriodicidad = model.TipoPeriodicidad?.ToString(),
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                PlantillaMensaje = model.PlantillaMensaje,
                Activo = model.Activo,
                FechaGeneracion = model.FechaGeneracion,
                MedioEnvio = model.MedioEnvio.ToString(),
                EntidadReferenciaId = model.EntidadReferenciaId,
                TipoEntidadOrigen = model.TipoEntidadOrigen,
                Destinatarios = model.Destinatarios.Select(DestinatarioAlertaConverter.ToDto).ToList(),
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static AlertaNotificacion ToModel(AlertaNotificacionDto dto)
        {
            return new AlertaNotificacion
            {
                Id = dto.Id,
                EventoDisparador = dto.EventoDisparador,
                DescripcionAlerta = dto.DescripcionAlerta,
                TipoAlerta = Enum.TryParse<TipoAlertaEnum>(dto.TipoAlerta, out var tipo) ? tipo : TipoAlertaEnum.Informativa,
                TipoPeriodicidad = Enum.TryParse<TipoPeriodicidadEnum>(dto.TipoPeriodicidad, out var peri) ? peri : null,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                PlantillaMensaje = dto.PlantillaMensaje,
                Activo = dto.Activo,
                FechaGeneracion = dto.FechaGeneracion,
                MedioEnvio = Enum.TryParse<MedioEnvioEnum>(dto.MedioEnvio, out var medio) ? medio : MedioEnvioEnum.Correo,
                EntidadReferenciaId = dto.EntidadReferenciaId,
                TipoEntidadOrigen = dto.TipoEntidadOrigen,
                Destinatarios = dto.Destinatarios.Select(DestinatarioAlertaConverter.ToModel).ToList(),
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
