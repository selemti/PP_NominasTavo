// Converter
using PP_Nominas.Models.Catalogos.Fiscal;
using PP_Nominas.Dtos.Catalogos.Fiscal;

namespace PP_Nominas.Converters.Catalogos.Fiscal
{
    public static class CuotaObreroPatronalConverter
    {
        public static CuotaObreroPatronalDto ToDto(CuotaObreroPatronal model)
        {
            if (model == null) return null!;

            return new CuotaObreroPatronalDto
            {
                Id = model.Id,
                Concepto = model.Concepto,
                PorcentajePatron = model.PorcentajePatron,
                PorcentajeEmpleado = model.PorcentajeEmpleado,
                VigenciaInicio = model.VigenciaInicio,
                VigenciaFin = model.VigenciaFin,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static CuotaObreroPatronal ToModel(CuotaObreroPatronalDto dto)
        {
            if (dto == null) return null!;

            var model = new CuotaObreroPatronal
            {
                Id = dto.Id,
                Concepto = dto.Concepto,
                PorcentajePatron = dto.PorcentajePatron,
                PorcentajeEmpleado = dto.PorcentajeEmpleado,
                VigenciaInicio = dto.VigenciaInicio,
                VigenciaFin = dto.VigenciaFin,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            return model;
        }
    }
}
