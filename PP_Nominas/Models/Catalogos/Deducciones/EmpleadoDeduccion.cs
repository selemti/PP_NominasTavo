// Modelo
using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Deducciones
{
    public partial class EmpleadoDeduccion : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _empleadoId = string.Empty;
        private string _deduccionId = string.Empty;
        private decimal? _valor;
        private int? _periodicidad;
        private DateTime? _fechaInicio;
        private DateTime? _fechaFin;
        private DateTime _fechaUltimaModificacion;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID de la asignación")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Empleado afectado")]
        public string EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        [Display(Name = "Deducción aplicada")]
        public string DeduccionId
        {
            get => _deduccionId;
            set => SetProperty(ref _deduccionId, value);
        }

        [Display(Name = "Valor a deducir")]
        public decimal? Valor
        {
            get => _valor;
            set => SetProperty(ref _valor, value);
        }

        [Display(Name = "(0 = Única, 1 = Mensual, 2 = Quincenal)")]
        public int? Periodicidad
        {
            get => _periodicidad;
            set => SetProperty(ref _periodicidad, value);
        }

        [Display(Name = "Inicio de la deducción")]
        public DateTime? FechaInicio
        {
            get => _fechaInicio;
            set => SetProperty(ref _fechaInicio, value);
        }

        [Display(Name = "Fin (nullable)")]
        public DateTime? FechaFin
        {
            get => _fechaFin;
            set => SetProperty(ref _fechaFin, value);
        }

        [Display(Name = "Fecha de última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        [Display(Name = "Usuario de última modificación")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
