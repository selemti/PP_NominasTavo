using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Asistencia;

namespace PP_Nominas.Converters
{
    public static class RangoToleranciaConverter
    {
        public static RangoToleranciaDto ToDto(RangoTolerancia model)
        {
            if (model == null) return null!;

            return new RangoToleranciaDto
            {
                Id = model.Id,
                Codigo = model.Codigo,
                Nombre = model.Nombre,
                MinutosDesde = model.MinutosDesde,
                MinutosHasta = model.MinutosHasta,
                Penalizacion = model.Penalizacion,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static RangoTolerancia ToModel(RangoToleranciaDto dto)
        {
            if (dto == null) return null!;

            var model = new RangoTolerancia
            {
                Id = dto.Id,
                Codigo = dto.Codigo,
                Nombre = dto.Nombre,
                MinutosDesde = dto.MinutosDesde,
                MinutosHasta = dto.MinutosHasta,
                Penalizacion = dto.Penalizacion,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            return model;
        }
    }
}
