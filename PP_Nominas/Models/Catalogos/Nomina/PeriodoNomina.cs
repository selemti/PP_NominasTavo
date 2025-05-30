using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    /// <summary>Representa un periodo de nómina registrado en el sistema.</summary>
    public partial class PeriodoNomina : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private TipoNominaEnum? _tipoNomina;
        private string _tipoPeriodoId = string.Empty;
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

        [Display(Name = "ID del periodo de nómina")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Fecha de inicio")]
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set => SetProperty(ref _fechaInicio, value);
        }

        [Display(Name = "Fecha de fin")]
        public DateTime FechaFin
        {
            get => _fechaFin;
            set => SetProperty(ref _fechaFin, value);
        }

        [Display(Name = "Tipo de nómina")]
        public TipoNominaEnum? TipoNomina
        {
            get => _tipoNomina;
            set => SetProperty(ref _tipoNomina, value);
        }

        [Display(Name = "Tipo de periodo")]
        public string TipoPeriodoId
        {
            get => _tipoPeriodoId;
            set => SetProperty(ref _tipoPeriodoId, value);
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
