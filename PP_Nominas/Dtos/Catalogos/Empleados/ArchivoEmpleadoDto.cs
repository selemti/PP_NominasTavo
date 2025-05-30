using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class ArchivoEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public int? TipoArchivo { get; set; }
        public string UrlArchivo { get; set; } = string.Empty;
        public DateTime? FechaCarga { get; set; }
        public bool? Vigente { get; set; }
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}