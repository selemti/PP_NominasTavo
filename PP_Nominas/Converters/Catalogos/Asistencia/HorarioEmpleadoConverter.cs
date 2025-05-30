using System;
using PP_Nominas.Models.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Converters.Catalogos.Asistencia
{
    public static class HorarioEmpleadoConverter
    {
        public static HorarioEmpleadoDto ToDto(HorarioEmpleado model)
        {
            return new HorarioEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                TurnoId = model.TurnoId ?? string.Empty,
                HorarioPlantillaId = model.HorarioPlantillaId ?? string.Empty,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                Vigente = model.Vigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static HorarioEmpleado ToModel(HorarioEmpleadoDto dto)
        {
            return new HorarioEmpleado
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                TurnoId = dto.TurnoId ?? string.Empty,
                HorarioPlantillaId = dto.HorarioPlantillaId ?? string.Empty,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Vigente = dto.Vigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
