using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Representa a un destinatario asociado a una alerta específica.</summary>
    public partial class DestinatarioAlerta : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _alertaNotificacionId = string.Empty;
        private string? _usuarioId;
        private string? _perfilId;
        private TipoDestinatarioEnum _tipoDestinatario;
        private bool _leido;
        private DateTime? _fechaLectura;

        [Display(Name = "ID del destinatario")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID de alerta asociada")]
        public string AlertaNotificacionId
        {
            get => _alertaNotificacionId;
            set => SetProperty(ref _alertaNotificacionId, value);
        }

        [Display(Name = "Usuario destinatario")]
        public string? UsuarioId
        {
            get => _usuarioId;
            set => SetProperty(ref _usuarioId, value);
        }

        [Display(Name = "Perfil destinatario")]
        public string? PerfilId
        {
            get => _perfilId;
            set => SetProperty(ref _perfilId, value);
        }

        [Display(Name = "Tipo de destinatario")]
        public TipoDestinatarioEnum TipoDestinatario
        {
            get => _tipoDestinatario;
            set => SetProperty(ref _tipoDestinatario, value);
        }

        [Display(Name = "Leído")]
        public bool Leido
        {
            get => _leido;
            set => SetProperty(ref _leido, value);
        }

        [Display(Name = "Fecha de lectura")]
        public DateTime? FechaLectura
        {
            get => _fechaLectura;
            set => SetProperty(ref _fechaLectura, value);
        }
    }
}
