using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class OrganigramaNodoDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Id { get; set; }
        public int Consucutivo { get; set; }

        private string _nombreDelPuestoAsignado { get; set; } // 🔹 Relación a la Persona
        public string NombreDelPuestoAsignado
        {
            get => _nombreDelPuestoAsignado;
            set
            {
                if (_nombreDelPuestoAsignado != value)
                {
                    _nombreDelPuestoAsignado = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _puestoId { get; set; }
        public string PuestoId
        {
            get { return _puestoId; }
            set
            {
                if (_puestoId != value)
                {
                    _puestoId = value;
                    OnPropertyChanged();
                }
            }
        }
        // 

        private string _empresaId { get; set; }
        public string EmpresaId
        {
            get { return _empresaId; }
            set
            {
                _empresaId = value;
                OnPropertyChanged();
            }
        }

        private string _nombreEmpresa { get; set; }
        public string NombreEmpresa
        {
            get { return _nombreEmpresa; }
            set
            {
                _nombreEmpresa = value;
                OnPropertyChanged();
            }
        }
        public string IdAsignacionPlazaEmpleado_Nominas { get; set; }
        private string _nombrePuesto;
        public string NombrePuesto
        {
            get => _nombrePuesto;
            set
            {
                if (_nombrePuesto != value)
                {
                    _nombrePuesto = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _nombrePersona;
        public string NombrePersona
        {
            get => _nombrePersona;
            set
            {
                if (_nombrePersona != value)
                {
                    _nombrePersona = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _fotoUrl;
        public string FotoUrl
        {
            get => _fotoUrl;
            set
            {
                if (_fotoUrl != value)
                {
                    _fotoUrl = value;
                    OnPropertyChanged();
                }
            }
        }
        //public List<OrganigramaNodo> Subordinados { get; set; }= new List<OrganigramaNodo>();

        public ObservableCollection<OrganigramaNodoDTO> Subordinados { get; set; } = new();



        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
