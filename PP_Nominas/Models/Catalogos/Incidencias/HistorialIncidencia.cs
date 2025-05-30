using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Incidencias
{
    /// <summary>
    /// Representa la clase HistorialIncidencia.
    /// </summary>
    public partial class HistorialIncidencia : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _incidenciaId = string.Empty;
        private DateTime? _fechaCambio;
        private string _descripcionCambio = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del historial de cambios")]
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

        [Display(Name = "Incidencia relacionada")]
        public string IncidenciaId
        {
            get => _incidenciaId;
            set
            {
                if (_incidenciaId != value)
                {
                    _incidenciaId = value;
                    OnPropertyChanged(nameof(IncidenciaId));
                }
            }
        }

        [Display(Name = "Fecha del cambio registrado")]
        public DateTime? FechaCambio
        {
            get => _fechaCambio;
            set
            {
                if (_fechaCambio != value)
                {
                    _fechaCambio = value;
                    OnPropertyChanged(nameof(FechaCambio));
                }
            }
        }

        [Display(Name = "Descripción del cambio realizado")]
        public string DescripcionCambio
        {
            get => _descripcionCambio;
            set
            {
                if (_descripcionCambio != value)
                {
                    _descripcionCambio = value;
                    OnPropertyChanged(nameof(DescripcionCambio));
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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
