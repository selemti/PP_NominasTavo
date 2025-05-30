using System.Net.Http.Json;
using System.Threading.Tasks;
using PP_Nominas.Models.Catalogos.Empleados;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PP_Nominas.ViewModel.Catalogos.Empleados;

/// <summary>ViewModel para la vista de detalle del empleado.</summary>
public class DetalleEmpleadoViewModel : BindableObject
{
    private readonly HttpClient httpClient = new();

    /// <summary>ID del empleado recibido por navegación.</summary>
    public string EmpleadoId { get; set; } = string.Empty;

    /// <summary>Instancia completa del empleado.</summary>
    public Empleado Empleado { get; set; } = new();

    /// <summary>Asignación activa actual del empleado (si existe).</summary>
    public AsignacionPlazaEmpleado? PlazaActiva =>
        Empleado?.Asignaciones?.FirstOrDefault(x => x.Activa);

    /// <summary>Indica si la plaza está vigente (sin fecha de liberación).</summary>
    public bool? Vigente => PlazaActiva?.FechaLiberacion == null;

    /// <summary>Carga la información del empleado desde la API.</summary>
    public async Task CargarEmpleadoAsync()
    {
        var resultado = await httpClient.GetFromJsonAsync<Empleado>($"api/Empleado/{EmpleadoId}");
        Empleado = resultado ?? new Empleado();

        OnPropertyChanged(nameof(Empleado));
        OnPropertyChanged(nameof(PlazaActiva));
        OnPropertyChanged(nameof(Vigente));
    }
}