using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Models.Catalogos.Shared
{
    /// <summary>Teléfono asociado a una persona o contacto.</summary>
    public class Telefono : INotifyPropertyChanged
    {
        private string? _id;
        private TipoTelefono _tipo;
        private string _numero = string.Empty;
        private string? _claveLada;
        private string? _extension;
        private bool _principal;
        private string? _observaciones;
        private DateTime _fechaUltimaModificacion;
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

        /// <summary>Identificador único del teléfono.</summary>
        [Display(Name = "Id")]
        public string? Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        /// <summary>Tipo de teléfono (Ej: Celular, Casa, Oficina, Emergencia).</summary>
        [Required(ErrorMessage = "El campo Tipo de teléfono es obligatorio.")]
        [Display(Name = "Tipo")]
        public TipoTelefono Tipo
        {
            get => _tipo;
            set => SetProperty(ref _tipo, value);
        }

        /// <summary>Número telefónico sin lada.</summary>
        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El número de teléfono no es válido.")]
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Número de teléfono inválido.")]
        [Display(Name = "Número")]
        public string Numero
        {
            get => _numero;
            set => SetProperty(ref _numero, value);
        }

        /// <summary>Clave lada nacional o internacional (Ej: 55, 33, +52).</summary>
        [Display(Name = "Clave LADA")]
        public string? ClaveLada
        {
            get => _claveLada;
            set => SetProperty(ref _claveLada, value);
        }

        /// <summary>Extensión interna (si aplica).</summary>
        [Display(Name = "Extensión")]
        public string? Extension
        {
            get => _extension;
            set => SetProperty(ref _extension, value);
        }

        /// <summary>Indica si este es el número principal de contacto.</summary>
        [Display(Name = "Principal")]
        public bool Principal
        {
            get => _principal;
            set => SetProperty(ref _principal, value);
        }

        /// <summary>Comentario adicional o nota sobre el teléfono.</summary>
        [Display(Name = "Observaciones")]
        public string? Observaciones
        {
            get => _observaciones;
            set => SetProperty(ref _observaciones, value);
        }

        /// <summary>Fecha de la última modificación del documento.</summary>
        [Display(Name = "Última modificación")]
        public DateTime FechaUltimaModificacion
        {
            get => _fechaUltimaModificacion;
            set => SetProperty(ref _fechaUltimaModificacion, value);
        }

        /// <summary>Usuario que realizó la última modificación.</summary>
        [Display(Name = "Modificado por")]
        public string UsuarioUltimaModificacion
        {
            get => _usuarioUltimaModificacion;
            set => SetProperty(ref _usuarioUltimaModificacion, value);
        }
    }
}
