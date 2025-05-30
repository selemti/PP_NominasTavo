using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PP_Nominas.Models.Catalogos.Empleados
{
    /// <summary>Movimiento histórico del empleado ante el IMSS.</summary>
    public class HistorialRegistroImss : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _nss = string.Empty;
        private string _registroPatronalId = string.Empty;
        private DateTime? _fechaAlta;
        private DateTime? _fechaBaja;
        private string _tipoMovimiento = string.Empty;
        private DateTime _fechaMovimiento = DateTime.MinValue;
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

        [Display(Name = "ID del historial")]
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

        [Display(Name = "Registro patronal")]
        public string RegistroPatronalId
        {
            get => _registroPatronalId;
            set => SetProperty(ref _registroPatronalId, value);
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

        [Required]
        [Display(Name = "Tipo de movimiento")]
        public string TipoMovimiento
        {
            get => _tipoMovimiento;
            set => SetProperty(ref _tipoMovimiento, value);
        }

        [Display(Name = "Fecha del movimiento")]
        public DateTime FechaMovimiento
        {
            get => _fechaMovimiento;
            set => SetProperty(ref _fechaMovimiento, value);
        }

        [Display(Name = "Comentarios")]
        public string Comentarios
        {
            get => _comentarios;
            set => SetProperty(ref _comentarios, value);
        }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
