using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase EmpleadoCompensacion.
    /// </summary>
    public partial class EmpleadoCompensacion : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _compensacionId = string.Empty;
        private decimal? _valor;
        private int? _tipoAsignacion;
        private string _formula = string.Empty;
        private int? _periodicidad;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private bool _vigente;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID")]
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

        [Display(Name = "Empleado ID")]
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

        [Display(Name = "Compensación ID")]
        public string CompensacionId
        {
            get => _compensacionId;
            set
            {
                if (_compensacionId != value)
                {
                    _compensacionId = value;
                    OnPropertyChanged(nameof(CompensacionId));
                }
            }
        }

        [Display(Name = "Valor")]
        public decimal? Valor
        {
            get => _valor;
            set
            {
                if (_valor != value)
                {
                    _valor = value;
                    OnPropertyChanged(nameof(Valor));
                }
            }
        }

        [Display(Name = "Tipo de asignación")]
        public int? TipoAsignacion
        {
            get => _tipoAsignacion;
            set
            {
                if (_tipoAsignacion != value)
                {
                    _tipoAsignacion = value;
                    OnPropertyChanged(nameof(TipoAsignacion));
                }
            }
        }

        [Display(Name = "Fórmula de cálculo")]
        public string Formula
        {
            get => _formula;
            set
            {
                if (_formula != value)
                {
                    _formula = value;
                    OnPropertyChanged(nameof(Formula));
                }
            }
        }

        [Display(Name = "Periodicidad")]
        public int? Periodicidad
        {
            get => _periodicidad;
            set
            {
                if (_periodicidad != value)
                {
                    _periodicidad = value;
                    OnPropertyChanged(nameof(Periodicidad));
                }
            }
        }

        [Display(Name = "Fecha inicio")]
        public DateTime? FechaInicio
        {
            get => _fechaInicio;
            set
            {
                if (_fechaInicio != value)
                {
                    _fechaInicio = value;
                    OnPropertyChanged(nameof(FechaInicio));
                }
            }
        }

        [Display(Name = "Fecha fin")]
        public DateTime? FechaFin
        {
            get => _fechaFin;
            set
            {
                if (_fechaFin != value)
                {
                    _fechaFin = value;
                    OnPropertyChanged(nameof(FechaFin));
                }
            }
        }

        [Display(Name = "Vigente")]
        public bool Vigente
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

        [Display(Name = "Fecha de última modificación")]
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
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
