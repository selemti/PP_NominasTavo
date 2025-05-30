using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Dirección postal del empleado.</summary>
    public class Direccion : INotifyPropertyChanged
    {
        private string? _id;
        private string _calle = string.Empty;
        private string? _numeroExterior;
        private string? _numeroInterior;
        private string _colonia = string.Empty;
        private string _codigoPostal = string.Empty;
        private string _municipio = string.Empty;
        private string _localidad = string.Empty;
        private string _entidadFederativa = string.Empty;
        private string _pais = "México";
        private bool _principal;
        private string? _observaciones;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(name);
            return true;
        }

        /// <summary>Identificador único de la dirección.</summary>
        [Display(Name = "Id")]
        public string? Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Required(ErrorMessage = "El campo Calle es obligatorio.")]
        [Display(Name = "Calle")]
        public string Calle
        {
            get => _calle;
            set => SetProperty(ref _calle, value);
        }

        [Display(Name = "Número exterior")]
        public string? NumeroExterior
        {
            get => _numeroExterior;
            set => SetProperty(ref _numeroExterior, value);
        }

        [Display(Name = "Número interior")]
        public string? NumeroInterior
        {
            get => _numeroInterior;
            set => SetProperty(ref _numeroInterior, value);
        }

        [Display(Name = "Colonia")]
        public string Colonia
        {
            get => _colonia;
            set => SetProperty(ref _colonia, value);
        }

        [Required(ErrorMessage = "El campo Código Postal es obligatorio.")]
        [Display(Name = "Código postal")]
        public string CodigoPostal
        {
            get => _codigoPostal;
            set => SetProperty(ref _codigoPostal, value);
        }

        [Display(Name = "Municipio o delegación")]
        public string Municipio
        {
            get => _municipio;
            set => SetProperty(ref _municipio, value);
        }

        [Display(Name = "Localidad")]
        public string Localidad
        {
            get => _localidad;
            set => SetProperty(ref _localidad, value);
        }

        [Display(Name = "Entidad federativa")]
        public string EntidadFederativa
        {
            get => _entidadFederativa;
            set => SetProperty(ref _entidadFederativa, value);
        }

        [Display(Name = "País")]
        public string Pais
        {
            get => _pais;
            set => SetProperty(ref _pais, value);
        }

        [Display(Name = "Principal")]
        public bool Principal
        {
            get => _principal;
            set => SetProperty(ref _principal, value);
        }

        [Display(Name = "Observaciones")]
        public string? Observaciones
        {
            get => _observaciones;
            set => SetProperty(ref _observaciones, value);
        }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
