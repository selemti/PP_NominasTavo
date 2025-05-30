using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Biometria
{
    /// <summary>Dispositivo biométrico asignado a un centro de trabajo.</summary>
    public partial class DispositivoBiometrico : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _modelo = string.Empty;
        private string _numeroSerie = string.Empty;
        private string _ipAsignada = string.Empty;
        private int? _tipoDispositivo;
        private string _centroId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
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

        [Display(Name = "ID del dispositivo biométrico")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Modelo del dispositivo")]
        public string Modelo
        {
            get => _modelo;
            set => SetProperty(ref _modelo, value);
        }

        [Display(Name = "Número de serie")]
        public string NumeroSerie
        {
            get => _numeroSerie;
            set => SetProperty(ref _numeroSerie, value);
        }

        [Display(Name = "IP asignada")]
        public string IpAsignada
        {
            get => _ipAsignada;
            set => SetProperty(ref _ipAsignada, value);
        }

        [Display(Name = "Tipo de dispositivo")]
        public int? TipoDispositivo
        {
            get => _tipoDispositivo;
            set => SetProperty(ref _tipoDispositivo, value);
        }

        [Display(Name = "Centro asignado")]
        public string CentroId
        {
            get => _centroId;
            set => SetProperty(ref _centroId, value);
        }

        [Display(Name = "Fecha de última modificación")]
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
