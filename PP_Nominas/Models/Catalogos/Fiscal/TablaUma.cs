// Modelo corregido TablaUma
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Fiscal
{
    public partial class TablaUma : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private decimal? _valorUma;
        private DateTime? _fechaInicioVigencia;
        private DateTime? _fechaFinVigencia;
        private int? _ejercicioFiscal;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la UMA")]
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

        [Display(Name = "Valor monetario de la UMA")]
        public decimal? ValorUma
        {
            get => _valorUma;
            set
            {
                if (_valorUma != value)
                {
                    _valorUma = value;
                    OnPropertyChanged(nameof(ValorUma));
                }
            }
        }

        [Display(Name = "Fecha de inicio de vigencia")]
        public DateTime? FechaInicioVigencia
        {
            get => _fechaInicioVigencia;
            set
            {
                if (_fechaInicioVigencia != value)
                {
                    _fechaInicioVigencia = value;
                    OnPropertyChanged(nameof(FechaInicioVigencia));
                }
            }
        }

        [Display(Name = "Fecha fin de vigencia")]
        public DateTime? FechaFinVigencia
        {
            get => _fechaFinVigencia;
            set
            {
                if (_fechaFinVigencia != value)
                {
                    _fechaFinVigencia = value;
                    OnPropertyChanged(nameof(FechaFinVigencia));
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
