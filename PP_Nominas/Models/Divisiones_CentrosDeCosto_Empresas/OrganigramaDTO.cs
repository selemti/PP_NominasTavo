using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas
{
    public class OrganigramaDTO
    {
        public string Id { get; set; }
        
        // Relación directa al Centro de Costo
        public string CentroDeCostoId { get; set; }
        // Nodo principal del organigrama
        public OrganigramaNodoDTO NodoRaiz { get; set; }

        // Lista de puestos que se pueden asignar
        public List<PuestoDTO> Puestos { get; set; } = new List<PuestoDTO>();

        // Por si quieres habilitar/deshabilitar el organigrama
        public bool Activo { get; set; } 

    }
}
