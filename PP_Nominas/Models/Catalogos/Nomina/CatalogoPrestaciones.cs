using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Nomina
{
    /// <summary>Prestación definida por la empresa para sus empleados.</summary>
    public partial class CatalogoPrestaciones : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombrePrestacion = string.Empty;
        private string _descripcionPrestacion = string.Empty;
        private string _aplicaEmpresaId = string.Empty;
        private string _aplicaDivisionId = string.Empty;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la prestación")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Nombre de la prestación")]
        public string NombrePrestacion
        {
            get => _nombrePrestacion;
            set => SetProperty(ref _nombrePrestacion, value);
        }

        [Display(Name = "Descripción")]
        public string DescripcionPrestacion
        {
            get => _descripcionPrestacion;
            set => SetProperty(ref _descripcionPrestacion, value);
        }

        [Display(Name = "Empresa relacionada")]
        public string AplicaEmpresaId
        {
            get => _aplicaEmpresaId;
            set => SetProperty(ref _aplicaEmpresaId, value);
        }

        [Display(Name = "División relacionada")]
        public string AplicaDivisionId
        {
            get => _aplicaDivisionId;
            set => SetProperty(ref _aplicaDivisionId, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario de modificación")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
