using PP_Nominas.Models.Catalogos.Configuracion;
using PP_Nominas.Dtos.Catalogos.Configuracion;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Converters.Catalogos.Configuracion
{
    public static class ParametroSistemaConverter
    {
        public static ParametroSistemaDto ToDto(ParametroSistema model)
        {
            return new ParametroSistemaDto
            {
                Id = model.Id,
                ClaveParametro = model.ClaveParametro,
                ValorParametro = model.ValorParametro,
                DescripcionParametro = model.DescripcionParametro,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static ParametroSistema ToModel(ParametroSistemaDto dto)
        {
            return new ParametroSistema
            {
                Id = dto.Id,
                ClaveParametro = dto.ClaveParametro,
                ValorParametro = dto.ValorParametro,
                DescripcionParametro = dto.DescripcionParametro,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static List<ParametroSistemaDto> ToDtoList(List<ParametroSistema> models)
        {
            return models.Select(m => ToDto(m)).ToList();
        }

        public static List<ParametroSistema> ToModelList(List<ParametroSistemaDto> dtos)
        {
            return dtos.Select(dto => ToModel(dto)).ToList();
        }
    }
}
