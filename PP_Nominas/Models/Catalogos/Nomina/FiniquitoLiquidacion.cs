using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    /// <summary>Representa un finiquito o liquidación otorgado a un empleado.</summary>
    public partial class FiniquitoLiquidacion : INotifyPropertyChanged
    {
        private string _empleadoId = string.Empty;
        private DateTime _fechaFiniquito = DateTime.MinValue;
        private decimal _isrCalculado;
        private decimal _totalFiniquito;
        private List<ConceptoFiniquito> _conceptos = new();
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

        [Display(Name = "ID del empleado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Fecha del finiquito")]
        public DateTime FechaFiniquito
        {
            get => _fechaFiniquito;
            set => SetProperty(ref _fechaFiniquito, value);
        }

        [Display(Name = "ISR calculado")]
        public decimal IsrCalculado
        {
            get => _isrCalculado;
            set => SetProperty(ref _isrCalculado, value);
        }

        [Display(Name = "Total del finiquito")]
        public decimal TotalFiniquito
        {
            get => _totalFiniquito;
            set => SetProperty(ref _totalFiniquito, value);
        }

        [Display(Name = "Conceptos aplicados")]
        public List<ConceptoFiniquito> Conceptos
        {
            get => _conceptos;
            set => SetProperty(ref _conceptos, value);
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
