using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class ReciboNominaConverter
    {
        public static ReciboNominaDto ToDto(ReciboNomina model)
        {
            return new ReciboNominaDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                PeriodoNominaId = model.PeriodoNominaId ?? string.Empty,
                HorasExtrasTrabajadas = model.HorasExtrasTrabajadas,
                HorasExtrasAutorizadas = model.HorasExtrasAutorizadas,
                TotalPercepciones = model.TotalPercepciones,
                TotalDeducciones = model.TotalDeducciones,
                TotalNeto = model.TotalNeto,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ReciboNomina ToModel(ReciboNominaDto dto)
        {
            return new ReciboNomina
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                PeriodoNominaId = dto.PeriodoNominaId ?? string.Empty,
                HorasExtrasTrabajadas = dto.HorasExtrasTrabajadas,
                HorasExtrasAutorizadas = dto.HorasExtrasAutorizadas,
                TotalPercepciones = dto.TotalPercepciones,
                TotalDeducciones = dto.TotalDeducciones,
                TotalNeto = dto.TotalNeto,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
