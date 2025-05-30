// Converter
using PP_Nominas.Dtos.Catalogos.Fiscal;
using PP_Nominas.Models.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class TablaImssConverter
    {
        public static TablaImssDto ToDto(TablaImss model)
        {
            if (model == null) return null!;

            return new TablaImssDto
            {
                Id = model.Id,
                Concepto = model.Concepto,
                PorcentajePatronal = model.PorcentajePatronal,
                PorcentajeObrero = model.PorcentajeObrero,
                SalarioMinimoAplica = model.SalarioMinimoAplica,
                EjercicioFiscal = model.EjercicioFiscal,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static TablaImss ToModel(TablaImssDto dto)
        {
            if (dto == null) return null!;

            var model = new TablaImss
            {
                Id = dto.Id,
                Concepto = dto.Concepto,
                PorcentajePatronal = dto.PorcentajePatronal,
                PorcentajeObrero = dto.PorcentajeObrero,
                SalarioMinimoAplica = dto.SalarioMinimoAplica,
                EjercicioFiscal = dto.EjercicioFiscal,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            return model;
        }
    }
}
