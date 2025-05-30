using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Asistencia
{
    /// <summary>
    /// Representa la clase HorarioPlantilla.
    /// </summary>
    public partial class HorarioPlantilla : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _nombrePlantilla = string.Empty;
        private string _descripcionPlantilla = string.Empty;
        private string _turnoId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        /// <summary>
        /// Obtiene o establece Id.
        /// </summary>
        [Display(Name = "ID de la plantilla de horarios")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        /// <summary>
        /// Obtiene o establece NombrePlantilla.
        /// </summary>
        [Display(Name = "Nombre de la plantilla")]
        public string NombrePlantilla
        {
            get => _nombrePlantilla;
            set => SetProperty(ref _nombrePlantilla, value);
        }

        /// <summary>
        /// Obtiene o establece DescripcionPlantilla.
        /// </summary>
        [Display(Name = "Descripción breve del horario")]
        public string DescripcionPlantilla
        {
            get => _descripcionPlantilla;
            set => SetProperty(ref _descripcionPlantilla, value);
        }

        /// <summary>
        /// Obtiene o establece TurnoId.
        /// </summary>
        [Display(Name = "Turno base de la plantilla")]
        public string TurnoId
        {
            get => _turnoId;
            set => SetProperty(ref _turnoId, value);
        }

        /// <summary>
        /// Fecha de la última modificación del documento.
        /// </summary>
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        /// <summary>
        /// Identificador del usuario que realizó la última modificación.
        /// </summary>
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(name);
            return true;
        }
    }
}
