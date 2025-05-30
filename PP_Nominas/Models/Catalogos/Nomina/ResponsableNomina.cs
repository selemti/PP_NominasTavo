using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    /// <summary>Usuario responsable del proceso de nómina.</summary>
    public partial class ResponsableNomina : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _usuarioId = string.Empty;
        private TipoResponsabilidadEnum? _tipoResponsabilidad;
        private string _centroPagoNominaId = string.Empty;
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

        [Display(Name = "ID del responsable")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID de usuario")]
        public string UsuarioId
        {
            get => _usuarioId;
            set => SetProperty(ref _usuarioId, value);
        }

        [Display(Name = "Tipo de responsabilidad")]
        public TipoResponsabilidadEnum? TipoResponsabilidad
        {
            get => _tipoResponsabilidad;
            set => SetProperty(ref _tipoResponsabilidad, value);
        }

        [Display(Name = "Centro de pago de nómina")]
        public string CentroPagoNominaId
        {
            get => _centroPagoNominaId;
            set => SetProperty(ref _centroPagoNominaId, value);
        }

        [Display(Name = "Fecha de última modificación")]
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
