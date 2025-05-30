using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_Nominas.Models.Core;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Modelo completo de persona física con validaciones y estructura MAUI.</summary>
    public partial class Persona : NotifyPropertyChangedBase
    {
        private string _id = string.Empty;
        private string _nombre = string.Empty;
        private string _apellidoPaterno = string.Empty;
        private string _apellidoMaterno = string.Empty;
        private string _curp = string.Empty;
        private string _rfc = string.Empty;
        private string _correoPersonal = string.Empty;
        private string _email = string.Empty;
        private string _nacionalidad = "Mexicana";
        private EstadoCivilEnum? _estadoCivil;
        private SexoEnum _sexo;
        private TipoSangreEnum? _tipoSangre;
        private NivelEstudioEnum? _nivelEstudios;
        private DateTime? _fechaNacimiento;
        private List<Telefono> _telefonos = new();
        private List<Direccion> _direcciones = new();
        private DateTime _fechaUltimaModificacion = DateTime.MinValue;
        private string _UsuarioUltimaModificacion = string.Empty;

        [Display(Name = "ID")]
        public string Id { get => _id; set => SetProperty(ref _id, value); }

        [Required]
        [Display(Name = "Nombre(s)")]
        public string Nombre { get => _nombre; set => SetProperty(ref _nombre, value); }

        [Required]
        [Display(Name = "Apellido paterno")]
        public string ApellidoPaterno { get => _apellidoPaterno; set => SetProperty(ref _apellidoPaterno, value); }

        [Display(Name = "Apellido materno")]
        public string ApellidoMaterno { get => _apellidoMaterno; set => SetProperty(ref _apellidoMaterno, value); }

        [Display(Name = "Nombre completo")]
        public string NombreCompleto => $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}".Trim();

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get => _fechaNacimiento; set => SetProperty(ref _fechaNacimiento, value); }

        [Required]
        [StringLength(18, MinimumLength = 18)]
        [Display(Name = "CURP")]
        public string Curp { get => _curp; set => SetProperty(ref _curp, value); }

        [Required]
        [StringLength(13)]
        [Display(Name = "RFC")]
        public string Rfc { get => _rfc; set => SetProperty(ref _rfc, value); }

        [Required]
        [Display(Name = "Sexo")]
        public SexoEnum Sexo { get => _sexo; set => SetProperty(ref _sexo, value); }

        [Required]
        [Display(Name = "Estado civil")]
        public EstadoCivilEnum? EstadoCivil { get => _estadoCivil; set => SetProperty(ref _estadoCivil, value); }

        [Display(Name = "Tipo de sangre")]
        public TipoSangreEnum? TipoSangre { get => _tipoSangre; set => SetProperty(ref _tipoSangre, value); }

        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get => _nacionalidad; set => SetProperty(ref _nacionalidad, value); }

        [Required]
        [Display(Name = "Nivel de estudios")]
        public NivelEstudioEnum? NivelEstudios { get => _nivelEstudios; set => SetProperty(ref _nivelEstudios, value); }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo personal")]
        public string CorreoPersonal { get => _correoPersonal; set => SetProperty(ref _correoPersonal, value); }

        [Display(Name = "Correo electrónico")]
        public string Email { get => _email; set => SetProperty(ref _email, value); }

        [Display(Name = "Teléfonos")]
        public List<Telefono> Telefonos { get => _telefonos; set => SetProperty(ref _telefonos, value); }

        [Display(Name = "Direcciones")]
        public List<Direccion> Direcciones { get => _direcciones; set => SetProperty(ref _direcciones, value); }

        [Display(Name = "Dirección principal")]
        public Direccion Direccion
        {
            get
            {
                if (Direcciones == null || Direcciones.Count == 0)
                {
                    var nueva = new Direccion();
                    Direcciones = new List<Direccion> { nueva };
                    return nueva;
                }
                return Direcciones[0];
            }
            set
            {
                if (Direcciones == null) Direcciones = new List<Direccion>();
                if (Direcciones.Count == 0) Direcciones.Add(value);
                else Direcciones[0] = value;
                OnPropertyChanged();
            }
        }

        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion { get => _fechaUltimaModificacion; set => SetProperty(ref _fechaUltimaModificacion, value); }

        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion { get => _UsuarioUltimaModificacion; set => SetProperty(ref _UsuarioUltimaModificacion, value); }
    }
}
