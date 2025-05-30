using System;
using System.Linq;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Converters.Catalogos.Shared;
using PP_Nominas.Converters.Catalogos.Asistencia;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Converters.Catalogos.Empleados
{
    public static class EmpleadoConverter
    {
        public static EmpleadoDto ToDto(Empleado model)
        {
            return new EmpleadoDto
            {
                Id = model.Id ?? string.Empty,
                NumeroEmpleado = model.NumeroEmpleado ?? string.Empty,
                Persona = PersonaConverter.ToDto(model.Persona),
                Nss = model.Nss ?? string.Empty,
                FechaIngreso = model.FechaIngreso,
                TipoContrato = (int)model.TipoContrato,
                TipoHorario = (int)model.TipoHorario,
                EstatusEmpleado = (int)model.EstatusEmpleado,
                Asignaciones = model.Asignaciones.Select(AsignacionPlazaEmpleadoConverter.ToDto).ToList(),
                HistorialUbicaciones = model.HistorialUbicaciones.Select(UbicacionEmpleadoConverter.ToDto).ToList(),
                RegistrosImss = model.RegistrosImss.Select(RegistroImssConverter.ToDto).ToList(),
                Horarios = model.Horarios.Select(HorarioEmpleadoConverter.ToDto).ToList(),
                DatosPago = DatosPagoEmpleadoConverter.ToDto(model.DatosPago),
                Documentos = model.Documentos.Select(DocumentoEmpleadoConverter.ToDto).ToList(),
                ContactosEmergencia = model.ContactosEmergencia.Select(ContactoEmergenciaConverter.ToDto).ToList(),
                CorreoCorporativo = model.CorreoCorporativo ?? string.Empty,
                UsuarioRed = model.UsuarioRed ?? string.Empty,
                IdBiometrico = model.IdBiometrico ?? string.Empty,
                FotoPerfilUrl = model.FotoPerfilUrl ?? string.Empty,
                FechaUltimaModificacion = model.FechaUltimaModificacion,
                UsuarioUltimaModificacion = model.UsuarioUltimaModificacion ?? string.Empty
            };
        }

        public static Empleado ToModel(EmpleadoDto dto)
        {
            return new Empleado
            {
                Id = dto.Id ?? string.Empty,
                NumeroEmpleado = dto.NumeroEmpleado ?? string.Empty,
                Persona = PersonaConverter.ToModel(dto.Persona),
                Nss = dto.Nss ?? string.Empty,
                FechaIngreso = dto.FechaIngreso,
                TipoContrato = (TipoContratoEnum)(dto.TipoContrato ?? 0),
                TipoHorario = (TipoHorarioEnum)(dto.TipoHorario ?? 0),
                EstatusEmpleado = (EstatusEmpleadoEnum)(dto.EstatusEmpleado ?? 0),
                Asignaciones = dto.Asignaciones.Select(AsignacionPlazaEmpleadoConverter.ToModel).ToList(),
                HistorialUbicaciones = dto.HistorialUbicaciones.Select(UbicacionEmpleadoConverter.ToModel).ToList(),
                RegistrosImss = dto.RegistrosImss.Select(RegistroImssConverter.ToModel).ToList(),
                Horarios = dto.Horarios.Select(HorarioEmpleadoConverter.ToModel).ToList(),
                DatosPago = DatosPagoEmpleadoConverter.ToModel(dto.DatosPago),
                Documentos = dto.Documentos.Select(DocumentoEmpleadoConverter.ToModel).ToList(),
                ContactosEmergencia = dto.ContactosEmergencia.Select(ContactoEmergenciaConverter.ToModel).ToList(),
                CorreoCorporativo = dto.CorreoCorporativo ?? string.Empty,
                UsuarioRed = dto.UsuarioRed ?? string.Empty,
                IdBiometrico = dto.IdBiometrico ?? string.Empty,
                FotoPerfilUrl = dto.FotoPerfilUrl ?? string.Empty,
                FechaUltimaModificacion = dto.FechaUltimaModificacion,
                UsuarioUltimaModificacion = dto.UsuarioUltimaModificacion ?? string.Empty
            };
        }
    }
}
