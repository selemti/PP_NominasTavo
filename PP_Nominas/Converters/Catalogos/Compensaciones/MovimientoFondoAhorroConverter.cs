using PP_Nominas.Dtos.Catalogos.Compensaciones;
using PP_Nominas.Models.Catalogos.Compensaciones;

namespace PP_Nominas.Converters.Catalogos.Compensaciones
{
    public static class MovimientoFondoAhorroConverter
    {
        public static MovimientoFondoAhorro ToModel(MovimientoFondoAhorroDto dto)
        {
            if (dto == null) return null!;

            return new MovimientoFondoAhorro
            {
                Id = dto.Id,
                FondoAhorroId = dto.FondoAhorroId,
                TipoMovimiento = dto.TipoMovimiento,
                Monto = dto.Monto,
                FechaMovimiento = dto.FechaMovimiento,
                Descripcion = dto.Descripcion,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static MovimientoFondoAhorroDto ToDto(MovimientoFondoAhorro model)
        {
            if (model == null) return null!;

            return new MovimientoFondoAhorroDto
            {
                Id = model.Id,
                FondoAhorroId = model.FondoAhorroId,
                TipoMovimiento = model.TipoMovimiento,
                Monto = model.Monto,
                FechaMovimiento = model.FechaMovimiento,
                Descripcion = model.Descripcion,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }
    }
}
