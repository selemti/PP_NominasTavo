using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class UbicacionEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string SucursalId { get; set; } = string.Empty;
        public string NombreSucursal { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
