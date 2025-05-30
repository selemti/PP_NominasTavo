using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class CentroDeCostoDTO
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        //public TiposCentosDeCostoDTO Tipo { get; set; }
        //public bool ConFondo { get; set; }
        public bool Activa { get; set; }
        public List<AreaDTO> Areas { get; set; } = new List<AreaDTO>();
        public List<EmpresaDTO> Empresas { get; set; } = new List<EmpresaDTO>();
        public string OrganigramaId { get; set; }
    }

    public enum TiposCentosDeCostoDTO
    {
        Operativo,
        Obra,
        Invesion
    }
}
