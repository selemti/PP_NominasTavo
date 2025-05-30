using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Deducciones
{
    public partial class CatalogoDeducciones : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private int? _tipoDeduccion;
        private string _nombreDeduccion = string.Empty;
        private string _descripcionDeduccion = string.Empty;
        private string _aplicaEmpresaId = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la deducción")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "(0 = Fiscal, 1 = Crédito, 2 = Préstamo, 3 = Especial, 4 = FONACOT, 5 = Pensión Alimenticia, 6 = Otro, 7 = Multa Interna, 8 = Retención Judicial)")]
        public int? TipoDeduccion
        {
            get => _tipoDeduccion;
            set => SetProperty(ref _tipoDeduccion, value);
        }

        [Display(Name = "Nombre de la deducción")]
        public string NombreDeduccion
        {
            get => _nombreDeduccion;
            set => SetProperty(ref _nombreDeduccion, value);
        }

        [Display(Name = "Descripción de la deducción")]
        public string DescripcionDeduccion
        {
            get => _descripcionDeduccion;
            set => SetProperty(ref _descripcionDeduccion, value);
        }

        [Display(Name = "Empresa aplicable")]
        public string AplicaEmpresaId
        {
            get => _aplicaEmpresaId;
            set => SetProperty(ref _aplicaEmpresaId, value);
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
