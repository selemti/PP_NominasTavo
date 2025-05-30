// Converter
using PP_Nominas.Dtos.Catalogos.Fiscal;
using PP_Nominas.Models.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class TablaIsrConverter
    {
        public static TablaIsrDto ToDto(TablaIsr model)
        {
            if (model == null) return null!;

            return new TablaIsrDto
            {
                Id = model.Id,
                LimiteInferior = model.LimiteInferior,
                LimiteSuperior = model.LimiteSuperior,
                CuotaFija = model.CuotaFija,
                PorcentajeExcedente = model.PorcentajeExcedente,
                Periodo = model.Periodo,
                EjercicioFiscal = model.EjercicioFiscal,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static TablaIsr ToModel(TablaIsrDto dto)
        {
            if (dto == null) return null!;

            return new TablaIsr
            {
                Id = dto.Id,
                LimiteInferior = dto.LimiteInferior,
                LimiteSuperior = dto.LimiteSuperior,
                CuotaFija = dto.CuotaFija,
                PorcentajeExcedente = dto.PorcentajeExcedente,
                Periodo = dto.Periodo,
                EjercicioFiscal = dto.EjercicioFiscal,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
