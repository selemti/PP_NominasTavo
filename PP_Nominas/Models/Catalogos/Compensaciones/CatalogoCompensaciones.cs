using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PP_Nominas.Models.Catalogos.Compensaciones
{
    /// <summary>
    /// Representa la clase CatalogoCompensaciones.
    /// </summary>
    public partial class CatalogoCompensaciones : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private int? _tipoCompensacion;
        private string _nombreCompensacion = string.Empty;
        private string _descripcionCompensacion = string.Empty;
        private string _aplicaEmpresaId = string.Empty;
        private string _aplicaDivisionId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la compensación")]
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

        [Display(Name = "Tipo (0 = Bono, 1 = Comisión, 2 = Premio)")]
        public int? TipoCompensacion
        {
            get => _tipoCompensacion;
            set
            {
                if (_tipoCompensacion != value)
                {
                    _tipoCompensacion = value;
                    OnPropertyChanged(nameof(TipoCompensacion));
                }
            }
        }

        [Display(Name = "Nombre del concepto")]
        public string NombreCompensacion
        {
            get => _nombreCompensacion;
            set
            {
                if (_nombreCompensacion != value)
                {
                    _nombreCompensacion = value;
                    OnPropertyChanged(nameof(NombreCompensacion));
                }
            }
        }

        [Display(Name = "Descripción de la compensación")]
        public string DescripcionCompensacion
        {
            get => _descripcionCompensacion;
            set
            {
                if (_descripcionCompensacion != value)
                {
                    _descripcionCompensacion = value;
                    OnPropertyChanged(nameof(DescripcionCompensacion));
                }
            }
        }

        [Display(Name = "Empresa relacionada (opcional)")]
        public string AplicaEmpresaId
        {
            get => _aplicaEmpresaId;
            set
            {
                if (_aplicaEmpresaId != value)
                {
                    _aplicaEmpresaId = value;
                    OnPropertyChanged(nameof(AplicaEmpresaId));
                }
            }
        }

        [Display(Name = "División relacionada (opcional)")]
        public string AplicaDivisionId
        {
            get => _aplicaDivisionId;
            set
            {
                if (_aplicaDivisionId != value)
                {
                    _aplicaDivisionId = value;
                    OnPropertyChanged(nameof(AplicaDivisionId));
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

        [Display(Name = "Usuario que realizó la última modificación")]
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
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
