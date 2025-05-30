using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase IncapacidadMedica.
    /// </summary>
    public partial class IncapacidadMedica : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private int? _tipoIncapacidad;
        private int? _diasIncapacidad;
        private string _folioImss = string.Empty;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID único de la incapacidad")]
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

        [Display(Name = "Empleado afectado")]
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

        [Display(Name = "Tipo (0 = Enfermedad, 1 = Maternidad, 2 = Riesgo)")]
        public int? TipoIncapacidad
        {
            get => _tipoIncapacidad;
            set
            {
                if (_tipoIncapacidad != value)
                {
                    _tipoIncapacidad = value;
                    OnPropertyChanged(nameof(TipoIncapacidad));
                }
            }
        }

        [Display(Name = "Días autorizados por el IMSS")]
        public int? DiasIncapacidad
        {
            get => _diasIncapacidad;
            set
            {
                if (_diasIncapacidad != value)
                {
                    _diasIncapacidad = value;
                    OnPropertyChanged(nameof(DiasIncapacidad));
                }
            }
        }

        [Display(Name = "Folio de validación ante IMSS")]
        public string FolioImss
        {
            get => _folioImss;
            set
            {
                if (_folioImss != value)
                {
                    _folioImss = value;
                    OnPropertyChanged(nameof(FolioImss));
                }
            }
        }

        [Display(Name = "Fecha de inicio de la incapacidad")]
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

        [Display(Name = "Fecha de fin de la incapacidad")]
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

        [Display(Name = "Usuario de última modificación")]
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
