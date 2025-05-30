using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class TablaVacaciones : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private int? _aniosAntiguedadMinimo;
        private int? _aniosAntiguedadMaximo;
        private int? _diasVacaciones;
        private int? _ejercicioFiscal;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del rango de antigüedad")]
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

        [Display(Name = "Años mínimos cumplidos")]
        public int? AniosAntiguedadMinimo
        {
            get => _aniosAntiguedadMinimo;
            set
            {
                if (_aniosAntiguedadMinimo != value)
                {
                    _aniosAntiguedadMinimo = value;
                    OnPropertyChanged(nameof(AniosAntiguedadMinimo));
                }
            }
        }

        [Display(Name = "Años máximos cumplidos")]
        public int? AniosAntiguedadMaximo
        {
            get => _aniosAntiguedadMaximo;
            set
            {
                if (_aniosAntiguedadMaximo != value)
                {
                    _aniosAntiguedadMaximo = value;
                    OnPropertyChanged(nameof(AniosAntiguedadMaximo));
                }
            }
        }

        [Display(Name = "Días de vacaciones otorgados")]
        public int? DiasVacaciones
        {
            get => _diasVacaciones;
            set
            {
                if (_diasVacaciones != value)
                {
                    _diasVacaciones = value;
                    OnPropertyChanged(nameof(DiasVacaciones));
                }
            }
        }

        [Display(Name = "Año fiscal aplicable")]
        public int? EjercicioFiscal
        {
            get => _ejercicioFiscal;
            set
            {
                if (_ejercicioFiscal != value)
                {
                    _ejercicioFiscal = value;
                    OnPropertyChanged(nameof(EjercicioFiscal));
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

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
