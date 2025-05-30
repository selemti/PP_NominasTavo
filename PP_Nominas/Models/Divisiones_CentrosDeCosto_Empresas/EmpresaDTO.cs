using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class EmpresaDTO
    {
        public string Id { get; set; }
        public string RFC { get; set; }

        public string Nombre { get; set; }


        public string NoCuentaSantanderIngresos { get; set; }
        public string NoCuentaSantanderEgresos { get; set; }
        public string NoCuentaSantanderInversiones { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
