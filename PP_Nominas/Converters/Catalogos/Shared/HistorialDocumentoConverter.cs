using PP_Nominas.Models.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Shared
{
    public static class HistorialDocumentoConverter
    {
        public static HistorialDocumentoDto ToDto(HistorialDocumento model)
        {
            return new HistorialDocumentoDto
            {
                Id = model.Id ?? string.Empty,
                Entidad = model.Entidad ?? string.Empty,
                EntidadId = model.EntidadId ?? string.Empty,
                Snapshot = model.Snapshot ?? string.Empty,
                FechaCambio = model.FechaCambio,
                UsuarioId = model.UsuarioId ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static HistorialDocumento ToModel(HistorialDocumentoDto dto)
        {
            return new HistorialDocumento
            {
                Id = dto.Id ?? string.Empty,
                Entidad = dto.Entidad ?? string.Empty,
                EntidadId = dto.EntidadId ?? string.Empty,
                Snapshot = dto.Snapshot ?? string.Empty,
                FechaCambio = dto.FechaCambio,
                UsuarioId = dto.UsuarioId ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
