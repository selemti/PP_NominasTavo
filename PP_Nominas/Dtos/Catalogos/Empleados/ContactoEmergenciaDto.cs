using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class ContactoEmergenciaDto
    {
        public string Nombre { get; set; } = string.Empty;
        public string Parentesco { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public bool Principal { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
