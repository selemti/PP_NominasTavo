using PP_Nominas.Dtos.Catalogos.Compensaciones;
using PP_Nominas.Models.Catalogos.Compensaciones;

namespace PP_Nominas.Converters.Catalogos.Compensaciones
{
    public static class FondoAhorroConverter
    {
        public static FondoAhorro ToModel(FondoAhorroDto dto)
        {
            if (dto == null) return null!;

            return new FondoAhorro
            {
                Id = dto.Id,
                EmpleadoId = dto.EmpleadoId,
                SaldoActual = dto.SaldoActual,
                PorcentajeAportacion = dto.PorcentajeAportacion,
                Vigente = dto.Vigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static FondoAhorroDto ToDto(FondoAhorro model)
        {
            if (model == null) return null!;

            return new FondoAhorroDto
            {
                Id = model.Id,
                EmpleadoId = model.EmpleadoId,
                SaldoActual = model.SaldoActual,
                PorcentajeAportacion = model.PorcentajeAportacion,
                Vigente = model.Vigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }
    }
}
