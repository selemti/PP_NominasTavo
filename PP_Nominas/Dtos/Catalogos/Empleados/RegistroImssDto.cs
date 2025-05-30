using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class RegistroImssDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string Nss { get; set; } = string.Empty;
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Movimiento { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.MinValue;
        public string Comentarios { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
