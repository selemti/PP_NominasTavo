using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class ContratoEmpleadoConverter
    {
        public static ContratoEmpleadoDto ToDto(ContratoEmpleado model)
        {
            return new ContratoEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                TipoContrato = model.TipoContrato,
                FechaInicioContrato = model.FechaInicioContrato,
                FechaFinContrato = model.FechaFinContrato,
                Vigente = model.Vigente,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static ContratoEmpleado ToModel(ContratoEmpleadoDto dto)
        {
            return new ContratoEmpleado
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                TipoContrato = dto.TipoContrato,
                FechaInicioContrato = dto.FechaInicioContrato,
                FechaFinContrato = dto.FechaFinContrato,
                Vigente = dto.Vigente,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
