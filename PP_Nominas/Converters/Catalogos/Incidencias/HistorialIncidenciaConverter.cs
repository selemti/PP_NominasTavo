using PP_Nominas.Dtos.Catalogos.Incidencias;
using PP_Nominas.Models.Catalogos.Incidencias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Converters.Catalogos.Incidencias
{
    public static class HistorialIncidenciaConverter
    {
        public static HistorialIncidenciaDto ToDto(HistorialIncidencia model)
        {
            if (model == null) return new HistorialIncidenciaDto();

            return new HistorialIncidenciaDto
            {
                Id = model.Id,
                IncidenciaId = model.IncidenciaId,
                FechaCambio = model.FechaCambio,
                DescripcionCambio = model.DescripcionCambio,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static HistorialIncidencia ToModel(HistorialIncidenciaDto dto)
        {
            if (dto == null) return new HistorialIncidencia();

            return new HistorialIncidencia
            {
                Id = dto.Id,
                IncidenciaId = dto.IncidenciaId,
                FechaCambio = dto.FechaCambio,
                DescripcionCambio = dto.DescripcionCambio,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static List<HistorialIncidenciaDto> ToDtoList(IEnumerable<HistorialIncidencia> modelList)
        {
            return modelList?.Select(ToDto).ToList() ?? new List<HistorialIncidenciaDto>();
        }

        public static List<HistorialIncidencia> ToModelList(IEnumerable<HistorialIncidenciaDto> dtoList)
        {
            return dtoList?.Select(ToModel).ToList() ?? new List<HistorialIncidencia>();
        }
    }
}
