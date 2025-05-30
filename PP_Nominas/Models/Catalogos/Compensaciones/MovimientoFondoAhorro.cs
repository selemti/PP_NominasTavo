using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase MovimientoFondoAhorro.
    /// </summary>
    public partial class MovimientoFondoAhorro : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _fondoAhorroId = string.Empty;
        private int? _tipoMovimiento;
        private decimal? _monto;
        private DateTime? _fechaMovimiento;
        private string _descripcion = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del movimiento")]
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

        [Display(Name = "Fondo relacionado")]
        public string FondoAhorroId
        {
            get => _fondoAhorroId;
            set
            {
                if (_fondoAhorroId != value)
                {
                    _fondoAhorroId = value;
                    OnPropertyChanged(nameof(FondoAhorroId));
                }
            }
        }

        [Display(Name = "(0 = Aportación, 1 = Retiro, 2 = Interés generado)")]
        public int? TipoMovimiento
        {
            get => _tipoMovimiento;
            set
            {
                if (_tipoMovimiento != value)
                {
                    _tipoMovimiento = value;
                    OnPropertyChanged(nameof(TipoMovimiento));
                }
            }
        }

        [Display(Name = "Monto del movimiento")]
        public decimal? Monto
        {
            get => _monto;
            set
            {
                if (_monto != value)
                {
                    _monto = value;
                    OnPropertyChanged(nameof(Monto));
                }
            }
        }

        [Display(Name = "Fecha de operación")]
        public DateTime? FechaMovimiento
        {
            get => _fechaMovimiento;
            set
            {
                if (_fechaMovimiento != value)
                {
                    _fechaMovimiento = value;
                    OnPropertyChanged(nameof(FechaMovimiento));
                }
            }
        }

        [Display(Name = "Descripción breve del movimiento")]
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    OnPropertyChanged(nameof(Descripcion));
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
