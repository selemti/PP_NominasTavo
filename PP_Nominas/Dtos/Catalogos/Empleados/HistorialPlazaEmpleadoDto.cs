using System;

namespace PP_Nominas.Dtos.Catalogos.Empleados
{
    public class HistorialPlazaEmpleadoDto
    {
        public string Id { get; set; } = string.Empty;
        public string EmpleadoId { get; set; } = string.Empty;
        public string PlazaIdAnterior { get; set; } = string.Empty;
        public string PlazaIdNueva { get; set; } = string.Empty;
        public DateTime? FechaCambio { get; set; }
        public string MotivoCambio { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
