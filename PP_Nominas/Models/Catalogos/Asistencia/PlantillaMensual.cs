using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    public partial class PlantillaMensual : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private int? _mes;
        private int? _ao;
        private string _horarioPlantillaId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la plantilla mensual")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Mes aplicable (1-12)")]
        public int? Mes
        {
            get => _mes;
            set => SetProperty(ref _mes, value);
        }

        [Display(Name = "Año aplicable")]
        public int? AO
        {
            get => _ao;
            set => SetProperty(ref _ao, value);
        }

        [Display(Name = "Horario usado en el mes")]
        public string HorarioPlantillaId
        {
            get => _horarioPlantillaId;
            set => SetProperty(ref _horarioPlantillaId, value);
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
