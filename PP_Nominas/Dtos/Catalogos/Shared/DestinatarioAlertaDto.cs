using System;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class DestinatarioAlertaDto
    {
        public string Id { get; set; } = string.Empty;
        public string AlertaNotificacionId { get; set; } = string.Empty;
        public string? UsuarioId { get; set; }
        public string? PerfilId { get; set; }
        public string TipoDestinatario { get; set; } = string.Empty;
        public bool Leido { get; set; }
        public DateTime? FechaLectura { get; set; }
    }
}
