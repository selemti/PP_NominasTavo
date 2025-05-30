using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class PuestoDTO
    {
        public string Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Clave { get; set; }

        public bool Activo { get; set; } = true;

    }
}
