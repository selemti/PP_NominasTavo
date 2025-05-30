using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class CentroPagoNominaConverter
    {
        public static CentroPagoNominaDto ToDto(CentroPagoNomina model)
        {
            return new CentroPagoNominaDto
            {
                Id = model.Id ?? string.Empty,
                NombreCentroPago = model.NombreCentroPago ?? string.Empty,
                FechaCorteQuincena1 = model.FechaCorteQuincena1,
                FechaCorteQuincena2 = model.FechaCorteQuincena2,
                FechaPagoQuincena1 = model.FechaPagoQuincena1,
                FechaPagoQuincena2 = model.FechaPagoQuincena2,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static CentroPagoNomina ToModel(CentroPagoNominaDto dto)
        {
            return new CentroPagoNomina
            {
                Id = dto.Id ?? string.Empty,
                NombreCentroPago = dto.NombreCentroPago ?? string.Empty,
                FechaCorteQuincena1 = dto.FechaCorteQuincena1,
                FechaCorteQuincena2 = dto.FechaCorteQuincena2,
                FechaPagoQuincena1 = dto.FechaPagoQuincena1,
                FechaPagoQuincena2 = dto.FechaPagoQuincena2,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
