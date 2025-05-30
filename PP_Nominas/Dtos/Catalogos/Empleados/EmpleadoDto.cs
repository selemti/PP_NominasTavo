using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Dtos.Catalogos.Shared;
using PP_Nominas.Dtos.Catalogos.Asistencia;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class EmpleadoDto
    {
        public string? Id { get; set; }

        [Required]
        [Display(Name = "Número de empleado")]
        public string NumeroEmpleado { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Datos personales")]
        public PersonaDto Persona { get; set; } = new();

        [Required(ErrorMessage = "El NSS es obligatorio.")]
        [Display(Name = "NSS")]
        public string Nss { get; set; } = string.Empty;

        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; } = DateTime.MinValue;

        [Display(Name = "Tipo de contrato")]
        public int? TipoContrato { get; set; }

        [Display(Name = "Tipo de horario")]
        public int? TipoHorario { get; set; }

        [Display(Name = "Estatus del empleado")]
        public int? EstatusEmpleado { get; set; }

        [Display(Name = "Asignaciones")]
        public List<AsignacionPlazaEmpleadoDto> Asignaciones { get; set; } = new();

        [Display(Name = "Historial de ubicaciones")]
        public List<UbicacionEmpleadoDto> HistorialUbicaciones { get; set; } = new();

        [Display(Name = "Registros IMSS")]
        public List<RegistroImssDto> RegistrosImss { get; set; } = new();

        [Display(Name = "Horarios asignados")]
        public List<HorarioEmpleadoDto> Horarios { get; set; } = new();

        [Display(Name = "Datos de pago")]
        public DatosPagoEmpleadoDto DatosPago { get; set; } = new();

        [Display(Name = "Documentos entregados")]
        public List<DocumentoEmpleadoDto> Documentos { get; set; } = new();

        [Display(Name = "Contactos de emergencia")]
        public List<ContactoEmergenciaDto> ContactosEmergencia { get; set; } = new();

        [Display(Name = "Correo corporativo")]
        public string CorreoCorporativo { get; set; } = string.Empty;

        [Display(Name = "Usuario de red")]
        public string UsuarioRed { get; set; } = string.Empty;

        [Display(Name = "ID biométrico")]
        public string IdBiometrico { get; set; } = string.Empty;

        [Display(Name = "Foto de perfil")]
        public string? FotoPerfilUrl { get; set; }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
