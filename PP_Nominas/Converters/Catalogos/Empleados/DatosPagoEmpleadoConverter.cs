using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class DatosPagoEmpleadoConverter
    {
        public static DatosPagoEmpleadoDto ToDto(DatosPagoEmpleado model)
        {
            return new DatosPagoEmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                EmpleadoId = model.EmpleadoId ?? string.Empty,
                BancoId = model.BancoId ?? string.Empty,
                CuentaBancaria = model.CuentaBancaria ?? string.Empty,
                FormaPago = model.FormaPago,
                Vigente = model.Vigente,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                Banco = model.Banco ?? string.Empty,
                Clabe = model.Clabe ?? string.Empty,
                NumeroCuenta = model.NumeroCuenta ?? string.Empty,
                UsoCfdi = model.UsoCfdi ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static DatosPagoEmpleado ToModel(DatosPagoEmpleadoDto dto)
        {
            return new DatosPagoEmpleado
            {
                Id = dto.Id ?? string.Empty,
                EmpleadoId = dto.EmpleadoId ?? string.Empty,
                BancoId = dto.BancoId ?? string.Empty,
                CuentaBancaria = dto.CuentaBancaria ?? string.Empty,
                FormaPago = dto.FormaPago,
                Vigente = dto.Vigente,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Banco = dto.Banco ?? string.Empty,
                Clabe = dto.Clabe ?? string.Empty,
                NumeroCuenta = dto.NumeroCuenta ?? string.Empty,
                UsoCfdi = dto.UsoCfdi ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
