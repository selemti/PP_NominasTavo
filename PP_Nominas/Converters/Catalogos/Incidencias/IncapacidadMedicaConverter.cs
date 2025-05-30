using PP_Nominas.Dtos.Catalogos.Incidencias;
using PP_Nominas.Models.Catalogos.Incidencias;
using System.Collections.Generic;
using System.Linq;

namespace PP_Nominas.Converters.Catalogos.Incidencias
{
    public static class IncapacidadMedicaConverter
    {
        public static IncapacidadMedicaDto ToDto(IncapacidadMedica model)
        {
            if (model == null) return new IncapacidadMedicaDto();

            return new IncapacidadMedicaDto
            {
                Id = model.Id,
                EmpleadoId = model.EmpleadoId,
                TipoIncapacidad = model.TipoIncapacidad,
                DiasIncapacidad = model.DiasIncapacidad,
                FolioImss = model.FolioImss,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static IncapacidadMedica ToModel(IncapacidadMedicaDto dto)
        {
            if (dto == null) return new IncapacidadMedica();

            return new IncapacidadMedica
            {
                Id = dto.Id,
                EmpleadoId = dto.EmpleadoId,
                TipoIncapacidad = dto.TipoIncapacidad,
                DiasIncapacidad = dto.DiasIncapacidad,
                FolioImss = dto.FolioImss,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };
        }

        public static List<IncapacidadMedicaDto> ToDtoList(IEnumerable<IncapacidadMedica> models)
        {
            return models?.Select(ToDto).ToList() ?? new List<IncapacidadMedicaDto>();
        }

        public static List<IncapacidadMedica> ToModelList(IEnumerable<IncapacidadMedicaDto> dtos)
        {
            return dtos?.Select(ToModel).ToList() ?? new List<IncapacidadMedica>();
        }
    }
}
