using System;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class TelefonoConverter
    {
        public static TelefonoDto ToDto(Telefono model)
        {
            return new TelefonoDto
            {
                Id = model.Id,
                Tipo = (int)model.Tipo,
                ClaveLada = model.ClaveLada,
                Numero = model.Numero,
                Extension = model.Extension,
                Principal = model.Principal,
                Observaciones = model.Observaciones,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static Telefono ToModel(TelefonoDto dto)
        {
            return new Telefono
            {
                Id = dto.Id,
                Tipo = (TipoTelefono)(dto.Tipo ?? 0), // 0 = default (Casa u otro definido)
                ClaveLada = dto.ClaveLada,
                Numero = dto.Numero,
                Extension = dto.Extension,
                Principal = dto.Principal,
                Observaciones = dto.Observaciones,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
