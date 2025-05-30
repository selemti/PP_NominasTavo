using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Shared
{
    public class AlertaNotificacionDto
    {
        public string Id { get; set; } = string.Empty;
        public string EventoDisparador { get; set; } = string.Empty;
        public string DescripcionAlerta { get; set; } = string.Empty;
        public string TipoAlerta { get; set; } = string.Empty;
        public string? TipoPeriodicidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string PlantillaMensaje { get; set; } = string.Empty;
        public bool Activo { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string MedioEnvio { get; set; } = string.Empty;
        public string? EntidadReferenciaId { get; set; }
        public string? TipoEntidadOrigen { get; set; }
        public List<DestinatarioAlertaDto> Destinatarios { get; set; } = new();
        public DateTime FechaUltimaModificacion { get; set; }
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}
