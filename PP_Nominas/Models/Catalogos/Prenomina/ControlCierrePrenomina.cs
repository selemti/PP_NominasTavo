using System;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;

namespace PP_Nominas.Models.Catalogos.Prenomina
{
    public partial class ControlCierrePrenomina : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _periodoNominaId = string.Empty;
        private DateTime? _fechaCierre;
        private string _usuarioCierreId = string.Empty;
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _usuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID del cierre de prenómina")]
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        [Display(Name = "Periodo de nómina")]
        public string PeriodoNominaId
        {
            get => _periodoNominaId;
            set => SetProperty(ref _periodoNominaId, value);
        }

        [Display(Name = "Fecha de cierre")]
        public DateTime? FechaCierre
        {
            get => _fechaCierre;
            set => SetProperty(ref _fechaCierre, value);
        }

        [Display(Name = "Usuario de cierre")]
        public string UsuarioCierreId
        {
            get => _usuarioCierreId;
            set => SetProperty(ref _usuarioCierreId, value);
        }

        [Display(Name = "Fecha de modificación")]
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
