using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    /// <summary>Representa el recibo de nómina de un empleado.</summary>
    public partial class ReciboNomina : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _periodoNominaId = string.Empty;
        private double _horasExtrasTrabajadas;
        private double _horasExtrasAutorizadas;
        private decimal _totalPercepciones;
        private decimal _totalDeducciones;
        private decimal _totalNeto;
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

        [Display(Name = "ID del recibo")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Empleado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Periodo de nómina")]
        public string PeriodoNominaId
        {
            get => _periodoNominaId;
            set => SetProperty(ref _periodoNominaId, value);
        }

        [Display(Name = "Horas extras trabajadas")]
        public double HorasExtrasTrabajadas
        {
            get => _horasExtrasTrabajadas;
            set => SetProperty(ref _horasExtrasTrabajadas, value);
        }

        [Display(Name = "Horas extras autorizadas")]
        public double HorasExtrasAutorizadas
        {
            get => _horasExtrasAutorizadas;
            set => SetProperty(ref _horasExtrasAutorizadas, value);
        }

        [Display(Name = "Total de percepciones")]
        public decimal TotalPercepciones
        {
            get => _totalPercepciones;
            set => SetProperty(ref _totalPercepciones, value);
        }

        [Display(Name = "Total de deducciones")]
        public decimal TotalDeducciones
        {
            get => _totalDeducciones;
            set => SetProperty(ref _totalDeducciones, value);
        }

        [Display(Name = "Total neto")]
        public decimal TotalNeto
        {
            get => _totalNeto;
            set => SetProperty(ref _totalNeto, value);
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
