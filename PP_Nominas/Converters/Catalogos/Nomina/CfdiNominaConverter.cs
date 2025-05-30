using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class CfdiNominaConverter
    {
        public static CfdiNominaDto ToDto(CfdiNomina model)
        {
            return new CfdiNominaDto
            {
                Id = model.Id ?? string.Empty,
                ReciboNominaId = model.ReciboNominaId ?? string.Empty,
                Uuid = model.Uuid ?? string.Empty,
                SelloDigital = model.SelloDigital ?? string.Empty,
                FechaTimbre = model.FechaTimbre,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static CfdiNomina ToModel(CfdiNominaDto dto)
        {
            return new CfdiNomina
            {
                Id = dto.Id ?? string.Empty,
                ReciboNominaId = dto.ReciboNominaId ?? string.Empty,
                Uuid = dto.Uuid ?? string.Empty,
                SelloDigital = dto.SelloDigital ?? string.Empty,
                FechaTimbre = dto.FechaTimbre,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
