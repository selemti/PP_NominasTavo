using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase TabuladorSalarial.
    /// </summary>
    public partial class TabuladorSalarial : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _puestoId = string.Empty;
        private decimal? _salarioMinimo;
        private decimal? _salarioMaximo;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del tabulador")]
        public string Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        [Display(Name = "Puesto relacionado")]
        public string PuestoId
        {
            get => _puestoId;
            set
            {
                if (_puestoId != value)
                {
                    _puestoId = value;
                    OnPropertyChanged(nameof(PuestoId));
                }
            }
        }

        [Display(Name = "Salario mínimo para puesto")]
        public decimal? SalarioMinimo
        {
            get => _salarioMinimo;
            set
            {
                if (_salarioMinimo != value)
                {
                    _salarioMinimo = value;
                    OnPropertyChanged(nameof(SalarioMinimo));
                }
            }
        }

        [Display(Name = "Salario máximo para puesto")]
        public decimal? SalarioMaximo
        {
            get => _salarioMaximo;
            set
            {
                if (_salarioMaximo != value)
                {
                    _salarioMaximo = value;
                    OnPropertyChanged(nameof(SalarioMaximo));
                }
            }
        }

        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set
            {
                if (_fechaUltimaModificacion != value)
                {
                    _fechaUltimaModificacion = value;
                    OnPropertyChanged(nameof(FechaUltimaModificacion));
                }
            }
        }

        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set
            {
                if (_usuarioUltimaModificacion != value)
                {
                    _usuarioUltimaModificacion = value;
                    OnPropertyChanged(nameof(UsuarioUltimaModificacion));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
