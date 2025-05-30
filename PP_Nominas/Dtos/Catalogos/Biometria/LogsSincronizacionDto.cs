using System;

namespace PP_Nominas.Dtos.Catalogos.Biometria
{
    public class LogsSincronizacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string DispositivoId { get; set; } = string.Empty;
        public DateTime? FechaEvento { get; set; }
        public string DescripcionLog { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
