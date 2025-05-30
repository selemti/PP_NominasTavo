// Converter
using PP_Nominas.Dtos.Catalogos.Fiscal;
using PP_Nominas.Models.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class TablaInfonavitConverter
    {
        public static TablaInfonavitDto ToDto(TablaInfonavit model)
        {
            if (model == null) return null!;

            return new TablaInfonavitDto
            {
                Id = model.Id,
                TipoDescuento = model.TipoDescuento,
                ValorDescuento = model.ValorDescuento,
                Descripcion = model.Descripcion,
                EjercicioFiscal = model.EjercicioFiscal,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static TablaInfonavit ToModel(TablaInfonavitDto dto)
        {
            if (dto == null) return null!;

            var model = new TablaInfonavit
            {
                Id = dto.Id,
                TipoDescuento = dto.TipoDescuento,
                ValorDescuento = dto.ValorDescuento,
                Descripcion = dto.Descripcion,
                EjercicioFiscal = dto.EjercicioFiscal,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            return model;
        }
    }
}
