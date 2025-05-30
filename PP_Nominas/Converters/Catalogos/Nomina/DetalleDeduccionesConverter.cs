using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class DetalleDeduccionesConverter
    {
        public static DetalleDeduccionesDto ToDto(DetalleDeducciones model)
        {
            return new DetalleDeduccionesDto
            {
                Id = model.Id ?? string.Empty,
                ReciboNominaId = model.ReciboNominaId ?? string.Empty,
                TipoDeduccionId = model.TipoDeduccionId ?? string.Empty,
                Monto = model.Monto,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static DetalleDeducciones ToModel(DetalleDeduccionesDto dto)
        {
            return new DetalleDeducciones
            {
                Id = dto.Id ?? string.Empty,
                ReciboNominaId = dto.ReciboNominaId ?? string.Empty,
                TipoDeduccionId = dto.TipoDeduccionId ?? string.Empty,
                Monto = dto.Monto,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
