// Converter
using PP_Nominas.Models.Catalogos.Deducciones;
using PP_Nominas.Dtos.Catalogos.Deducciones;
using System;

namespace PP_Nominas.Converters.Catalogos.Deducciones
{
    public static class EmpleadoDeduccionConverter
    {
        public static EmpleadoDeduccionDto ToDto(EmpleadoDeduccion model)
        {
            if (model == null) return null!;

            return new EmpleadoDeduccionDto
            {
                Id = model.Id,
                EmpleadoId = model.EmpleadoId,
                DeduccionId = model.DeduccionId,
                Valor = model.Valor,
                Periodicidad = model.Periodicidad,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion
            };
        }

        public static EmpleadoDeduccion ToModel(EmpleadoDeduccionDto dto)
        {
            if (dto == null) return null!;

            var model = new EmpleadoDeduccion
            {
                Id = dto.Id,
                EmpleadoId = dto.EmpleadoId,
                DeduccionId = dto.DeduccionId,
                Valor = dto.Valor,
                Periodicidad = dto.Periodicidad,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion
            };

            return model;
        }
    }
}
