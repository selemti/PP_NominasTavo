using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Representa una alerta generada en el sistema para notificar a uno o más destinatarios.</summary>
    public partial class AlertaNotificacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _eventoDisparador = string.Empty;
        private string _descripcionAlerta = string.Empty;
        private TipoAlertaEnum _tipoAlerta;
        private TipoPeriodicidadEnum? _tipoPeriodicidad;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private string _plantillaMensaje = string.Empty;
        private bool _activo;
        private DateTime _fechaGeneracion;
        private MedioEnvioEnum _medioEnvio;
        private string? _entidadReferenciaId;
        private string? _tipoEntidadOrigen;
        private List<DestinatarioAlerta> _destinatarios = new();
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la alerta")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Evento disparador")]
        public string EventoDisparador { get => _eventoDisparador; set => SetProperty(ref _eventoDisparador, value); }

        [Display(Name = "Descripción")]
        public string DescripcionAlerta { get => _descripcionAlerta; set => SetProperty(ref _descripcionAlerta, value); }

        [Display(Name = "Tipo de alerta")]
        public TipoAlertaEnum TipoAlerta { get => _tipoAlerta; set => SetProperty(ref _tipoAlerta, value); }

        [Display(Name = "Periodicidad")]
        public TipoPeriodicidadEnum? TipoPeriodicidad { get => _tipoPeriodicidad; set => SetProperty(ref _tipoPeriodicidad, value); }

        [Display(Name = "Fecha de inicio")]
        public DateTime? FechaInicio { get => _fechaInicio; set => SetProperty(ref _fechaInicio, value); }

        [Display(Name = "Fecha de fin")]
        public DateTime? FechaFin { get => _fechaFin; set => SetProperty(ref _fechaFin, value); }

        [Display(Name = "Plantilla")]
        public string PlantillaMensaje { get => _plantillaMensaje; set => SetProperty(ref _plantillaMensaje, value); }

        [Display(Name = "¿Activa?")]
        public bool Activo { get => _activo; set => SetProperty(ref _activo, value); }

        [Display(Name = "Fecha de generación")]
        public DateTime FechaGeneracion { get => _fechaGeneracion; set => SetProperty(ref _fechaGeneracion, value); }

        [Display(Name = "Medio de envío")]
        public MedioEnvioEnum MedioEnvio { get => _medioEnvio; set => SetProperty(ref _medioEnvio, value); }

        [Display(Name = "ID de entidad asociada")]
        public string? EntidadReferenciaId { get => _entidadReferenciaId; set => SetProperty(ref _entidadReferenciaId, value); }

        [Display(Name = "Tipo de entidad asociada")]
        public string? TipoEntidadOrigen { get => _tipoEntidadOrigen; set => SetProperty(ref _tipoEntidadOrigen, value); }

        [Display(Name = "Destinatarios")]
        public List<DestinatarioAlerta> Destinatarios { get => _destinatarios; set => SetProperty(ref _destinatarios, value); }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
