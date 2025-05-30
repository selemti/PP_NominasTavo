using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    public partial class PlantillaTurnoDetalle : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _plantillaId = string.Empty;
        private DateTime? _fecha;
        private string _turnoId = string.Empty;
        private string _plazaId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del detalle de turno")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID de la plantilla base mensual")]
        public string PlantillaId
        {
            get => _plantillaId;
            set => SetProperty(ref _plantillaId, value);
        }

        [Display(Name = "Fecha del turno asignado")]
        public DateTime? Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        [Display(Name = "Turno aplicado ese día")]
        public string TurnoId
        {
            get => _turnoId;
            set => SetProperty(ref _turnoId, value);
        }

        [Display(Name = "Plaza a la que se asigna el turno")]
        public string PlazaId
        {
            get => _plazaId;
            set => SetProperty(ref _plazaId, value);
        }

        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
