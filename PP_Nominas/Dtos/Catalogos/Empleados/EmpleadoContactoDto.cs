using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class EmpleadoContactoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string NombreContacto { get; set; } = string.Empty;
        public int? Parentesco { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}