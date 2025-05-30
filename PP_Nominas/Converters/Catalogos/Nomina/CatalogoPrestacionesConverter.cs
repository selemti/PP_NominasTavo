using PP_Nominas.Models.Catalogos.Nomina;
using PP_Nominas.Dtos.Catalogos.Nomina;

namespace PP_Nominas.Converters.Catalogos.Nomina
{
    public static class CatalogoPrestacionesConverter
    {
        public static CatalogoPrestacionesDto ToDto(CatalogoPrestaciones model)
        {
            return new CatalogoPrestacionesDto
            {
                Id = model.Id ?? string.Empty,
                NombrePrestacion = model.NombrePrestacion ?? string.Empty,
                DescripcionPrestacion = model.DescripcionPrestacion ?? string.Empty,
                AplicaEmpresaId = model.AplicaEmpresaId ?? string.Empty,
                AplicaDivisionId = model.AplicaDivisionId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static CatalogoPrestaciones ToModel(CatalogoPrestacionesDto dto)
        {
            return new CatalogoPrestaciones
            {
                Id = dto.Id ?? string.Empty,
                NombrePrestacion = dto.NombrePrestacion ?? string.Empty,
                DescripcionPrestacion = dto.DescripcionPrestacion ?? string.Empty,
                AplicaEmpresaId = dto.AplicaEmpresaId ?? string.Empty,
                AplicaDivisionId = dto.AplicaDivisionId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
