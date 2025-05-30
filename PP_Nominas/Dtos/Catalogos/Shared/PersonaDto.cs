using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class PersonaDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string Curp { get; set; } = string.Empty;
        public string Rfc { get; set; } = string.Empty;
        public string CorreoPersonal { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = "Mexicana";
        public int? EstadoCivil { get; set; }
        public int? Sexo { get; set; }
        public int? TipoSangre { get; set; }
        public int? NivelEstudio { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DireccionDto Direccion { get; set; } = new();
        public List<DireccionDto> Direcciones { get; set; } = new();
        public List<TelefonoDto> Telefonos { get; set; } = new();
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
