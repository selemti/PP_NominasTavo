using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Representa un paso dentro de un flujo de validación.</summary>
    public partial class PasoFlujoValidacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _flujoValidacionId = string.Empty;
        private int _orden;
        private string _nombrePaso = string.Empty;
        private TipoResponsableEnum _tipoResponsable;
        private string? _usuarioId;
        private string? _perfilId;
        private EstadoPasoFlujoEnum _estado;
        private string? _comentarios;
        private DateTime? _fechaValidacion;
        private string? _ipValidacion;
        private string? _dispositivo;

        [Display(Name = "ID del paso")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Flujo relacionado")]
        public string FlujoValidacionId { get => _flujoValidacionId; set => SetProperty(ref _flujoValidacionId, value); }

        [Display(Name = "Orden")]
        public int Orden { get => _orden; set => SetProperty(ref _orden, value); }

        [Display(Name = "Nombre del paso")]
        public string NombrePaso { get => _nombrePaso; set => SetProperty(ref _nombrePaso, value); }

        [Display(Name = "Tipo de responsable")]
        public TipoResponsableEnum TipoResponsable { get => _tipoResponsable; set => SetProperty(ref _tipoResponsable, value); }

        [Display(Name = "Usuario responsable")]
        public string? UsuarioId { get => _usuarioId; set => SetProperty(ref _usuarioId, value); }

        [Display(Name = "Perfil responsable")]
        public string? PerfilId { get => _perfilId; set => SetProperty(ref _perfilId, value); }

        [Display(Name = "Estado")]
        public EstadoPasoFlujoEnum Estado { get => _estado; set => SetProperty(ref _estado, value); }

        [Display(Name = "Comentarios")]
        public string? Comentarios { get => _comentarios; set => SetProperty(ref _comentarios, value); }

        [Display(Name = "Fecha de validación")]
        public DateTime? FechaValidacion { get => _fechaValidacion; set => SetProperty(ref _fechaValidacion, value); }

        [Display(Name = "IP de validación")]
        public string? IpValidacion { get => _ipValidacion; set => SetProperty(ref _ipValidacion, value); }

        [Display(Name = "Dispositivo")]
        public string? Dispositivo { get => _dispositivo; set => SetProperty(ref _dispositivo, value); }
    }
}
