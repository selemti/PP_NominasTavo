using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class DetallePercepcionesConverter
    {
        public static DetallePercepcionesDto ToDto(DetallePercepciones model)
        {
            return new DetallePercepcionesDto
            {
                Id = model.Id ?? string.Empty,
                ReciboNominaId = model.ReciboNominaId ?? string.Empty,
                TipoCompensacionId = model.TipoCompensacionId ?? string.Empty,
                Monto = model.Monto,
                TipoFiscalizacion = model.TipoFiscalizacion,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static DetallePercepciones ToModel(DetallePercepcionesDto dto)
        {
            return new DetallePercepciones
            {
                Id = dto.Id ?? string.Empty,
                ReciboNominaId = dto.ReciboNominaId ?? string.Empty,
                TipoCompensacionId = dto.TipoCompensacionId ?? string.Empty,
                Monto = dto.Monto,
                TipoFiscalizacion = dto.TipoFiscalizacion,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
