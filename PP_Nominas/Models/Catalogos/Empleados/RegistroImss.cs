using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados
{
    /// <summary>Registro actual del IMSS para el empleado.</summary>
    public class RegistroImss : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _nss = string.Empty;
        private DateTime? _fechaAlta;
        private DateTime? _fechaBaja;
        private string _movimiento = string.Empty;
        private DateTime _fecha = DateTime.MinValue;
        private string _comentarios = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

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

        [Display(Name = "ID")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID del empleado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "NSS")]
        public string Nss
        {
            get => _nss;
            set => SetProperty(ref _nss, value);
        }

        [Display(Name = "Fecha de alta")]
        public DateTime? FechaAlta
        {
            get => _fechaAlta;
            set => SetProperty(ref _fechaAlta, value);
        }

        [Display(Name = "Fecha de baja")]
        public DateTime? FechaBaja
        {
            get => _fechaBaja;
            set => SetProperty(ref _fechaBaja, value);
        }

        [Display(Name = "Movimiento")]
        public string Movimiento
        {
            get => _movimiento;
            set => SetProperty(ref _movimiento, value);
        }

        [Display(Name = "Fecha del movimiento")]
        public DateTime Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        [Display(Name = "Comentarios")]
        public string Comentarios
        {
            get => _comentarios;
            set => SetProperty(ref _comentarios, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario que modificó")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
