using System;
using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia
{
    public static class ChecadaRemotaConverter
    {
        public static ChecadaRemotaDto ToDto(ChecadaRemota model)
        {
            return new ChecadaRemotaDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                FechaHora = model.FechaHora,
                TipoEvento = model.TipoEvento,
                Latitud = model.Latitud,
                Longitud = model.Longitud,
                UbicacionId = model.UbicacionId ?? string.Empty,
                FotoAdjunta = model.FotoAdjunta ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ChecadaRemota ToModel(ChecadaRemotaDto dto)
        {
            return new ChecadaRemota
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                FechaHora = dto.FechaHora,
                TipoEvento = dto.TipoEvento,
                Latitud = dto.Latitud,
                Longitud = dto.Longitud,
                UbicacionId = dto.UbicacionId ?? string.Empty,
                FotoAdjunta = dto.FotoAdjunta ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
