using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class DireccionConverter
    {
        public static DireccionDto ToDto(Direccion model)
        {
            return new DireccionDto
            {
                Id = model.Id,
                Calle = model.Calle ?? string.Empty,
                NumeroExterior = model.NumeroExterior ?? string.Empty,
                NumeroInterior = model.NumeroInterior ?? string.Empty,
                Colonia = model.Colonia ?? string.Empty,
                CodigoPostal = model.CodigoPostal ?? string.Empty,
                Municipio = model.Municipio ?? string.Empty,
                Localidad = model.Localidad ?? string.Empty,
                EntidadFederativa = model.EntidadFederativa ?? string.Empty,
                Pais = model.Pais ?? "México",
                Principal = model.Principal,
                Observaciones = model.Observaciones ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Direccion ToModel(DireccionDto dto)
        {
            return new Direccion
            {
                Id = dto.Id,
                Calle = dto.Calle ?? string.Empty,
                NumeroExterior = dto.NumeroExterior ?? string.Empty,
                NumeroInterior = dto.NumeroInterior ?? string.Empty,
                Colonia = dto.Colonia ?? string.Empty,
                CodigoPostal = dto.CodigoPostal ?? string.Empty,
                Municipio = dto.Municipio ?? string.Empty,
                Localidad = dto.Localidad ?? string.Empty,
                EntidadFederativa = dto.EntidadFederativa ?? string.Empty,
                Pais = dto.Pais ?? "México",
                Principal = dto.Principal,
                Observaciones = dto.Observaciones ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
