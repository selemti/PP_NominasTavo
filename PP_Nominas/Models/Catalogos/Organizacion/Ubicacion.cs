using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Organizacion
{
    /// <summary>Representa una ubicación geográfica con validación de asistencia por radio o polígono.</summary>
    public partial class Ubicacion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombre = string.Empty;
        private decimal? _latitud;
        private decimal? _longitud;
        private decimal? _radio;
        private int? _tipoUbicacion;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la ubicación")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Display(Name = "Nombre de la ubicación")]
        public string Nombre { get => _nombre; set => SetProperty(ref _nombre, value); }

        [Display(Name = "Latitud")]
        public decimal? Latitud { get => _latitud; set => SetProperty(ref _latitud, value); }

        [Display(Name = "Longitud")]
        public decimal? Longitud { get => _longitud; set => SetProperty(ref _longitud, value); }

        [Display(Name = "Radio (m)")]
        public decimal? Radio { get => _radio; set => SetProperty(ref _radio, value); }

        [Display(Name = "Tipo de ubicación")]
        public int? TipoUbicacion { get => _tipoUbicacion; set => SetProperty(ref _tipoUbicacion, value); }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion { get => _usuarioUltimaModificacion; set => SetProperty(ref _usuarioUltimaModificacion, value); }
    }
}
