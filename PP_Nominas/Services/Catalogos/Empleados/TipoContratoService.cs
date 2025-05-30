using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PP_Nominas.Models.Catalogos.Empleados;

namespace PP_Nominas.Services.Catalogos.Empleados;

/// <summary>Servicio para consumir el API de TipoContrato.</summary>
public class TipoContratoService
{
    private readonly HttpClient _httpClient;

    public TipoContratoService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(App.BackURLBaseAddress)
        };
    }

    /// <summary>Obtiene todos los tipos de contrato activos.</summary>
    public async Task<List<TipoContrato>> ObtenerTodosAsync()
    {
        try
        {
            var contratos = await _httpClient.GetFromJsonAsync<List<TipoContrato>>("api/TipoContrato");
            return contratos ?? new List<TipoContrato>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener tipos de contrato: {ex.Message}");
            return new List<TipoContrato>();
        }
    }

    /// <summary>Inserta un nuevo tipo de contrato.</summary>
    public async Task<bool> InsertarAsync(TipoContrato contrato)
    {
        try
        {
            contrato.FechaUltimaModificacion = DateTime.Now;
            contrato.UsuarioUltimaModificacion = "admin"; // Cambiar por usuario real

            var response = await _httpClient.PostAsJsonAsync("api/TipoContrato", contrato);
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al insertar tipo de contrato: {ex.Message}");
            return false;
        }
    }
}
