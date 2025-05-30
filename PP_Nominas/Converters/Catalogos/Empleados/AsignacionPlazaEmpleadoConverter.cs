using System;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class AsignacionPlazaEmpleadoConverter
    {
        public static AsignacionPlazaEmpleadoDto ToDto(AsignacionPlazaEmpleado model)
        {
            return new AsignacionPlazaEmpleadoDto
            {
                Id = model.Id,
                EmpleadoId = model.EmpleadoId,
                PlazaId = model.PlazaId,
                Salario = model.Salario,
                TipoSalario = (int)model.TipoSalario,
                FechaInicio = model.FechaInicio,
                FechaFin = model.FechaFin,
                Vigente = model.Vigente,
                FechaAsignacion = model.FechaAsignacion,
                FechaLiberacion = model.FechaLiberacion,
                Activa = model.Activa,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion,
                JornadaLaboral = (JornadaLaboralEnum?)model.JornadaLaboral,
                TurnoAsignado = (TipoHorarioEnum?)model.TurnoAsignado,
                EsRotativo = model.EsRotativo,
                PeriodicidadPago = model.PeriodicidadPago,
                Comentarios = model.Comentarios

            };
        }

        public static AsignacionPlazaEmpleado ToModel(AsignacionPlazaEmpleadoDto dto)
        {
            var tipoSalarioEnum = dto.TipoSalario.HasValue? (TipoSalarioEnum)dto.TipoSalario.Value : TipoSalarioEnum.NoEspecificado;
            return new AsignacionPlazaEmpleado
            {
                Id = dto.Id,
                EmpleadoId = dto.EmpleadoId,
                PlazaId = dto.PlazaId,
                Salario = dto.Salario,
                TipoSalario = tipoSalarioEnum,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Vigente = dto.Vigente,
                FechaAsignacion = dto.FechaAsignacion,
                FechaLiberacion = dto.FechaLiberacion,
                Activa = dto.Activa,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion,
                JornadaLaboral = dto.JornadaLaboral ?? JornadaLaboralEnum.TiempoCompleto,
                TurnoAsignado = dto.TurnoAsignado ?? TipoHorarioEnum.Diurno,
                EsRotativo = dto.EsRotativo,
                PeriodicidadPago = dto.PeriodicidadPago,
                Comentarios = dto.Comentarios,

            };
        }
    }
}
