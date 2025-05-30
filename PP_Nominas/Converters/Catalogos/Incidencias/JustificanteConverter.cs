using System;
using PP_Nominas.Models.Catalogos.Incidencias;
using PP_Nominas.Dtos.Catalogos.Incidencias;

namespace PP_Nominas.Converters.Catalogos.Incidencias
{
    public static class JustificanteConverter
    {
        public static JustificanteDto ToDto(Justificante model)
        {
            return new JustificanteDto
            {
                Id = model.Id,
                TipoJustificante = model.TipoJustificante,
                UrlDocumento = model.UrlDocumento,
                FechaEmision = model.FechaEmision,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Justificante ToModel(JustificanteDto dto)
        {
            return new Justificante
            {
                Id = dto.Id,
                TipoJustificante = dto.TipoJustificante,
                UrlDocumento = dto.UrlDocumento,
                FechaEmision = dto.FechaEmision,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
