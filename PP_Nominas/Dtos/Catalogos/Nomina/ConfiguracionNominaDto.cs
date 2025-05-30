using System;
using System.Collections.Generic;

namespace PP_Nominas.Dtos.Catalogos.Nomina
{
    public class ConfiguracionNominaDto
    {
        public string Id { get; set; } = string.Empty;
        public string GrupoEmpresaId { get; set; } = string.Empty;
        public string TipoNomina { get; set; } = string.Empty;  // ✅ correcto para enums en DTOs
        public List<int>? DiasPago { get; set; }
        public string CentroTrabajoId { get; set; } = string.Empty;
        public DateTime FechaUltimaModificacion { get; set; } = DateTime.MinValue;
        public string UsuarioUltimaModificacion { get; set; } = string.Empty;
    }
}