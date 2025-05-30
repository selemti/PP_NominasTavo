using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class DivisionesDTO
    {
        public string Id { get; set; }

        public string Nombre { get; set; }
        public bool Activa { get; set; }
        public List<CentroDeCostoDTO> CentrosDeCosto { get; set; } = new List<CentroDeCostoDTO>();
    }
}
