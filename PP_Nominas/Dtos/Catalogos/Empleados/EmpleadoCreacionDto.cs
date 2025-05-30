using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP_Nominas.Dtos.Catalogos.Asistencia;
using PP_Nominas.Dtos.Catalogos.Shared;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class EmpleadoCreacionDto
    {
        public string? NumeroEmpleado { get; set; }
        public PersonaDto? Persona { get; set; }
        public string? Nss { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public int? TipoContrato { get; set; }
        public int? TipoHorario { get; set; }
        public int? EstatusEmpleado { get; set; }
        public DatosPagoEmpleadoDto? DatosPago { get; set; }
        public List<AsignacionPlazaEmpleadoDto>? Asignaciones { get; set; }
        public List<HorarioEmpleadoDto>? Horarios { get; set; }
        public List<RegistroImssDto>? RegistrosImss { get; set; }
        public List<UbicacionEmpleadoDto>? HistorialUbicaciones { get; set; }
        public List<DocumentoEmpleadoDto>? Documentos { get; set; }
        public List<ContactoEmergenciaDto>? ContactosEmergencia { get; set; }
        public string? CorreoCorporativo { get; set; }
        public string? UsuarioRed { get; set; }
        public string? IdBiometrico { get; set; }
        public string? FotoPerfilUrl { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.UtcNow;
        public string? UsuarioUltimaModificacion { get; set; }
    }
}
