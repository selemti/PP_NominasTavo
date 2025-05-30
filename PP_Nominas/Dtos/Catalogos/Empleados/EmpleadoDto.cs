using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Shared;
using System;
using System.Collections.Generic;
namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class EmpleadoDto
    {
        public string? Id { get; set; }
        public string NumeroEmpleado { get; set; } = string.Empty;
        public PersonaDto Persona { get; set; } = new();
        public string Nss { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; } = DateTime.MinValue;
        public int? TipoContrato { get; set; }
        public int? TipoHorario { get; set; }
        public int? EstatusEmpleado { get; set; }
        public List<AsignacionPlazaEmpleadoDto> Asignaciones { get; set; } = new();
        public List<UbicacionEmpleadoDto> HistorialUbicaciones { get; set; } = new();
        public List<RegistroImssDto> RegistrosImss { get; set; } = new();
        public List<HorarioEmpleadoDto> Horarios { get; set; } = new();
        public DatosPagoEmpleadoDto DatosPago { get; set; } = new();
        public List<DocumentoEmpleadoDto> Documentos { get; set; } = new();
        public List<ContactoEmergenciaDto> ContactosEmergencia { get; set; } = new();
        public string CorreoCorporativo { get; set; } = string.Empty;
        public string UsuarioRed { get; set; } = string.Empty;
        public string IdBiometrico { get; set; } = string.Empty;
        public string? FotoPerfilUrl { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}