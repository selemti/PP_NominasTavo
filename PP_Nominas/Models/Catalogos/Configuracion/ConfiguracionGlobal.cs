using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Configuracion
{
    /// <summary>
    /// Representa la clase ConfiguracionGlobal.
    /// </summary>
    public partial class ConfiguracionGlobal : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _categoriaConfiguracion = string.Empty;
        private string _claveConfiguracion = string.Empty;
        private string _valorConfiguracion = string.Empty;
        private string _descripcionConfiguracion = string.Empty;
        private DateTime? _fechaInicioVigencia;
        private DateTime? _fechaFinVigencia;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la configuración")]
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

        [Display(Name = "Categoría de configuración (ej. Nómina, Asistencia)")]
        public string CategoriaConfiguracion
        {
            get => _categoriaConfiguracion;
            set
            {
                if (_categoriaConfiguracion != value)
                {
                    _categoriaConfiguracion = value;
                    OnPropertyChanged(nameof(CategoriaConfiguracion));
                }
            }
        }

        [Display(Name = "Clave interna de configuración")]
        public string ClaveConfiguracion
        {
            get => _claveConfiguracion;
            set
            {
                if (_claveConfiguracion != value)
                {
                    _claveConfiguracion = value;
                    OnPropertyChanged(nameof(ClaveConfiguracion));
                }
            }
        }

        [Display(Name = "ValorConfiguracion")]
        public string ValorConfiguracion
        {
            get => _valorConfiguracion;
            set
            {
                if (_valorConfiguracion != value)
                {
                    _valorConfiguracion = value;
                    OnPropertyChanged(nameof(ValorConfiguracion));
                }
            }
        }

        [Display(Name = "DescripcionConfiguracion")]
        public string DescripcionConfiguracion
        {
            get => _descripcionConfiguracion;
            set
            {
                if (_descripcionConfiguracion != value)
                {
                    _descripcionConfiguracion = value;
                    OnPropertyChanged(nameof(DescripcionConfiguracion));
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

        [Display(Name = "Fecha de fin de vigencia (nullable)")]
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
