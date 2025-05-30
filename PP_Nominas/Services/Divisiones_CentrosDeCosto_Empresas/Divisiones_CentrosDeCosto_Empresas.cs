using PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace PP_Nominas.Services.Divisiones_CentrosDeCosto_Empresas
{
    public class Divisiones_CentrosDeCosto_Empresas
    {
        private readonly HttpClient _httpClient;

        public Divisiones_CentrosDeCosto_Empresas()
        {
            _httpClient = new HttpClient();
            App app = App.Current as App;
            _httpClient.BaseAddress = new Uri("https://pp.gawa.mx/");
        }


        // Obtener todas las divisiones
        public async Task<List<DivisionesDTO>> GetDivisionesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DivisionesDTO>>("api/divisiones");
        }

        // Obtener una división por ID
        public async Task<DivisionesDTO> GetDivisionByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<DivisionesDTO>($"api/divisiones/{id}");
        }

        // Crear una división
        public async Task<bool> CreateDivisionAsync(DivisionesDTO division)
        {
            var response = await _httpClient.PostAsJsonAsync("api/divisiones", division);
            return response.IsSuccessStatusCode;
        }
    }
}
