using System;
namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class HistorialRegistroImssDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string Nss { get; set; } = string.Empty;
        public string RegistroPatronalId { get; set; } = string.Empty;
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
        public string TipoMovimiento { get; set; } = default!;
        public DateTime FechaMovimiento { get; set; } = default!;
        public string Comentarios { get; set; } = default!;
    }
}