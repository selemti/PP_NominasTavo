using System.Linq;
using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class FlujoValidacionConverter
    {
        public static FlujoValidacionDto ToDto(FlujoValidacion model)
        {
            return new FlujoValidacionDto
            {
                Id = model.Id,
                NombreFlujo = model.NombreFlujo,
                EntidadReferenciaId = model.EntidadReferenciaId,
                TipoEntidadOrigen = model.TipoEntidadOrigen,
                Pasos = model.Pasos.Select(PasoFlujoValidacionConverter.ToDto).ToList(),
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static FlujoValidacion ToModel(FlujoValidacionDto dto)
        {
            return new FlujoValidacion
            {
                Id = dto.Id,
                NombreFlujo = dto.NombreFlujo,
                EntidadReferenciaId = dto.EntidadReferenciaId,
                TipoEntidadOrigen = dto.TipoEntidadOrigen,
                Pasos = dto.Pasos.Select(PasoFlujoValidacionConverter.ToModel).ToList(),
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }
    }
}
