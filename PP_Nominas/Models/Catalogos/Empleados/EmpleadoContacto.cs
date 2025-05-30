using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Empleados
{
    public partial class EmpleadoContacto : NotifyPropertyChangedBase
    {
        private string? _id;
        private string? _empleadoId;
        private string? _nombreContacto;
        private int? _parentesco;
        private DateTime _fechaUltimaModificacion;
        private string? _usuarioUltimaModificacion;

        [Display(Name = "ID del contacto")]
        public string? Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "ID del empleado")]
        public string? EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Nombre completo del contacto")]
        public string? NombreContacto
        {
            get => _nombreContacto;
            set => SetProperty(ref _nombreContacto, value);
        }

        [Display(Name = "Parentesco (enum)")]
        public int? Parentesco
        {
            get => _parentesco;
            set => SetProperty(ref _parentesco, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario de última modificación")]
        public string? UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}