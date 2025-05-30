using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    public partial class ConfiguracionNomina : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _grupoEmpresaId = string.Empty;
        private TipoNominaEnum? _tipoNomina;
        private List<int> _diasPago = new();
        private string _centroTrabajoId = string.Empty;

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

        [Display(Name = "ID configuración")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Grupo de empresa")]
        public string GrupoEmpresaId
        {
            get => _grupoEmpresaId;
            set => SetProperty(ref _grupoEmpresaId, value);
        }

        [Display(Name = "Tipo de nómina")]
        public TipoNominaEnum? TipoNomina
        {
            get => _tipoNomina;
            set => SetProperty(ref _tipoNomina, value);
        }

        [Display(Name = "Días de pago")]
        public List<int> DiasPago
        {
            get => _diasPago;
            set => SetProperty(ref _diasPago, value);
        }

        [Display(Name = "Centro de trabajo")]
        public string CentroTrabajoId
        {
            get => _centroTrabajoId;
            set => SetProperty(ref _centroTrabajoId, value);
        }
    }
}
