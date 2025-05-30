using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Dtos.Catalogos.Empleados;
using PP_Nominas.Converters.Catalogos.Empleados;

namespace PP_Nominas.Services.Catalogos.Empleados
{
    public class EmpleadoService
    {
        private readonly HttpClient _httpClient;

        public EmpleadoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            try
            {
                var dtos = await _httpClient.GetFromJsonAsync<List<EmpleadoDto>>("api/Empleado");
                if (dtos == null)
                    return new List<Empleado>();

                var empleados = new List<Empleado>();
                foreach (var dto in dtos)
                {
                    empleados.Add(EmpleadoConverter.ToModel(dto));
                }

                return empleados;
            }
            catch
            {
                return new List<Empleado>();
            }
        }

        public async Task<bool> GuardarEmpleadoAsync(Empleado empleado)
        {
            try
            {
                var dto = EmpleadoConverter.ToDto(empleado);
                var response = await _httpClient.PostAsJsonAsync("api/Empleado", dto);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
