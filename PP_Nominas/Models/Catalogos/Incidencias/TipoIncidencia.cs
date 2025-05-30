using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Incidencias
{
    public partial class TipoIncidencia : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _nombreTipoIncidencia = string.Empty;
        private string _descripcionTipoIncidencia = string.Empty;
        private bool _requiereJustificante;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del tipo de incidencia")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre del tipo (Incapacidad, Permiso, etc.)")]
        public string NombreTipoIncidencia
        {
            get => _nombreTipoIncidencia;
            set => SetProperty(ref _nombreTipoIncidencia, value);
        }

        [Display(Name = "Descripción breve del tipo")]
        public string DescripcionTipoIncidencia
        {
            get => _descripcionTipoIncidencia;
            set => SetProperty(ref _descripcionTipoIncidencia, value);
        }

        [Display(Name = "Indica si necesita documento")]
        public bool RequiereJustificante
        {
            get => _requiereJustificante;
            set => SetProperty(ref _requiereJustificante, value);
        }

        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T value, string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
