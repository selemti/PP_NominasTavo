using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas;

namespace PP_Nominas.Services.Divisiones_CentrosDeCosto_Empresas
{
    public class OrganigramaService
    {
        private readonly HttpClient _httpClient;
        private string BaseUrl; // URL de tu API

        public OrganigramaService()
        {
            _httpClient = new HttpClient();
            App app = (App)Application.Current;
            BaseUrl = app.PP_FinanzasURL+"api/organigramas";
        }

        // 🔹 Obtener un organigrama por Centro de Costo
        public async Task<OrganigramaDTO> GetOrganigramaPorCentroDeCostoIdAsync(string centroDeCostoId)
        {
            var url = $"{BaseUrl}/centrodecosto/{centroDeCostoId}";
            var temp = await _httpClient.GetAsync(url);

            var organigramas = await _httpClient.GetFromJsonAsync<List<OrganigramaDTO>>(url);
            return organigramas?.FirstOrDefault();
        }

        // 🔹 Obtener todos los organigramas
        public async Task<List<OrganigramaDTO>> GetOrganigramasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<OrganigramaDTO>>(BaseUrl);
        }

        // 🔹 Obtener organigrama por Id
        public async Task<OrganigramaDTO> GetOrganigramaByIdAsync(string id)
        {
            var url = $"{BaseUrl}/{id}";
            return await _httpClient.GetFromJsonAsync<OrganigramaDTO>(url);
        }

        // 🔹 Crear un nuevo organigrama
        public async Task<bool> CreateOrganigramaAsync(OrganigramaDTO organigrama)
        {
            var response = await _httpClient.PostAsJsonAsync(BaseUrl, organigrama);
            return response.IsSuccessStatusCode;
        }

        // 🔹 Actualizar un organigrama existente
        public async Task<bool> UpdateOrganigramaAsync(string id, OrganigramaDTO organigrama)
        {
            var url = $"{BaseUrl}/{id}";
            var response = await _httpClient.PostAsJsonAsync(url, organigrama);
            return response.IsSuccessStatusCode;
        }

        // 🔹 Eliminar un organigrama
        public async Task<bool> DeleteOrganigramaAsync(string id)
        {
            var url = $"{BaseUrl}/{id}";
            var response = await _httpClient.DeleteAsync(url);
            return response.IsSuccessStatusCode;
        }

        
        public async Task<bool> AsignarPuestoANodoAsync(string organigramaId, string nodoId, string puestoId, string EmpresaId, string NombrePlaza)
        {
            var url = $"{BaseUrl}/{organigramaId}/nodos/{nodoId}/asignar-puesto";

            var payload = new { PuestoId = puestoId, EmpresaId = EmpresaId, NombrePlaza = NombrePlaza };

            var response = await _httpClient.PostAsJsonAsync(url, payload);

            return response.IsSuccessStatusCode;
        }

        // 🔹 Obtener puestos de un organigrama
        public async Task<List<PuestoDTO>> GetPuestosPorOrganigramaAsync(string organigramaId)
        {
            var url = $"{BaseUrl}/{organigramaId}/puestos";
            return await _httpClient.GetFromJsonAsync<List<PuestoDTO>>(url);
        }

        // 🔹 Agregar nuevo puesto
        public async Task<PuestoDTO> AgregarPuestoAsync(string organigramaId, PuestoDTO puesto)
        {
            var url = $"{BaseUrl}/{organigramaId}/puestos";
            var response = await _httpClient.PostAsJsonAsync(url, puesto);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<PuestoDTO>();
            return null;
        }

        // 🔹 Editar puesto
        public async Task<bool> EditarPuestoAsync(string organigramaId, string puestoId, PuestoDTO puesto)
        {
            var url = $"{BaseUrl}/{organigramaId}/puestos/{puestoId}";
            var response = await _httpClient.PostAsJsonAsync(url, puesto);
            return response.IsSuccessStatusCode;
        }

        // 🔹 Eliminar puesto
        public async Task<bool> EliminarPuestoAsync(string organigramaId, string puestoId)
        {
            var url = $"{BaseUrl}/{organigramaId}/puestos/{puestoId}/eliminar";
            var response = await _httpClient.PostAsync(url, null);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<OrganigramaNodoDTO>> ObtenerNodosPorOrganigramaId(string organigramaId)
        {
            var nodos = await _httpClient.GetFromJsonAsync<List<OrganigramaNodoDTO>>($"{BaseUrl}/{organigramaId}/nodos");
            return nodos ?? new List<OrganigramaNodoDTO>();
        }

        // 🔹 Actualizar un nodo individual
        public async Task<bool> ActualizarNodoAsync(string organigramaId, string nodoId, OrganigramaNodoDTO nodoActualizado)
        {
            var url = $"{BaseUrl}/{organigramaId}/nodos/{nodoId}";
            var response = await _httpClient.PostAsJsonAsync(url, nodoActualizado);
            return response.IsSuccessStatusCode;
        }
        /// <summary>
        /// Obtiene las plazas disponibles del organigrama (nodos sin asignación y con nombre definido).
        /// </summary>
        public async Task<List<OrganigramaNodoDTO>> ObtenerPlazasDisponiblesAsync(string organigramaId)
        {
            var nodos = await GetNodosPorOrganigramaId(organigramaId);

            return nodos?
                .Where(n => string.IsNullOrWhiteSpace(n.IdAsignacionPlazaEmpleado_Nominas) &&
                            !string.IsNullOrWhiteSpace(n.NombrePuesto))
                .OrderBy(n => n.NombrePuesto)
                .ToList() ?? new();
        }

        /// <summary>
        /// Método base reutilizable para obtener todos los nodos del organigrama.
        /// </summary>
        private async Task<List<OrganigramaNodoDTO>> GetNodosPorOrganigramaId(string organigramaId)
        {
            return await _httpClient.GetFromJsonAsync<List<OrganigramaNodoDTO>>($"{BaseUrl}/{organigramaId}/nodos")
                   ?? new List<OrganigramaNodoDTO>();
        }


    }
}
