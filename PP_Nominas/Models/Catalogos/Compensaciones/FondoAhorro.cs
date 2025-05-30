using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase FondoAhorro.
    /// </summary>
    public partial class FondoAhorro : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private decimal? _saldoActual;
        private decimal? _porcentajeAportacion;
        private bool? _vigente;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del fondo de ahorro")]
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

        [Display(Name = "Empleado participante")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set
            {
                if (_empleadoId != value)
                {
                    _empleadoId = value;
                    OnPropertyChanged(nameof(EmpleadoId));
                }
            }
        }

        [Display(Name = "Saldo acumulado")]
        public decimal? SaldoActual
        {
            get => _saldoActual;
            set
            {
                if (_saldoActual != value)
                {
                    _saldoActual = value;
                    OnPropertyChanged(nameof(SaldoActual));
                }
            }
        }

        [Display(Name = "Porcentaje de aportación")]
        public decimal? PorcentajeAportacion
        {
            get => _porcentajeAportacion;
            set
            {
                if (_porcentajeAportacion != value)
                {
                    _porcentajeAportacion = value;
                    OnPropertyChanged(nameof(PorcentajeAportacion));
                }
            }
        }

        [Display(Name = "Fondo activo o cerrado")]
        public bool? Vigente
        {
            get => _vigente;
            set
            {
                if (_vigente != value)
                {
                    _vigente = value;
                    OnPropertyChanged(nameof(Vigente));
                }
            }
        }

        [Display(Name = "Fecha de la última modificación")]
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

        [Display(Name = "Usuario que realizó la última modificación")]
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
