using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Input;
using PP_Nominas.Models.Catalogos.Empleados;
using PP_Nominas.Models.Divisiones_CentrosDeCosto_Empresas;
using PP_Nominas.Models.Catalogos.Shared;
using Microsoft.Maui.Controls;

namespace PP_Nominas.ViewModel.Catalogos.Empleados
{
    /// <summary>ViewModel para la pantalla principal de empleados.</summary>
    public class EmpleadoPageViewModel : BindableObject
    {
        private readonly HttpClient httpClient;

        public ObservableCollection<Empleado> Empleados { get; } = new();
        public ObservableCollection<EmpresaDTO> Empresas { get; } = new();
        public ObservableCollection<DivisionesDTO> Divisiones { get; } = new();
        public ObservableCollection<CentroDeCostoDTO> CentrosCosto { get; } = new();
        public ObservableCollection<string> EstatusEmpleados { get; } = new(Enum.GetNames(typeof(EstatusEmpleadoEnum)));

        public ICommand BuscarCommand { get; }

        public EmpleadoPageViewModel()
        {
            httpClient = new HttpClient { BaseAddress = new Uri(App.BackURLBaseAddress) };
            BuscarCommand = new Command(async () => await BuscarAsync());
            _ = InicializarAsync();
        }

        private EmpresaDTO? empresaSeleccionada;
        public EmpresaDTO? EmpresaSeleccionada
        {
            get => empresaSeleccionada;
            set
            {
                if (empresaSeleccionada != value)
                {
                    empresaSeleccionada = value;
                    OnPropertyChanged();

                    // ✅ Solo recargar si no hay divisiones ya visibles
                    if (Divisiones.Count == 0)
                        _ = CargarDivisionesAsync();

                    _ = BuscarAsync();
                }
            }
        }


        private DivisionesDTO? divisionSeleccionada;
        public DivisionesDTO? DivisionSeleccionada
        {
            get => divisionSeleccionada;
            set
            {
                if (divisionSeleccionada != value)
                {
                    divisionSeleccionada = value;
                    OnPropertyChanged();

                    // ✅ Limpiar empresas
                    Empresas.Clear();
                    EmpresaSeleccionada = null;
                    OnPropertyChanged(nameof(Empresas));
                    OnPropertyChanged(nameof(EmpresaSeleccionada));

                    // ✅ Cargar centros de costo según la nueva división
                    CentrosCosto.Clear();
                    if (value?.CentrosDeCosto != null)
                    {
                        foreach (var centro in value.CentrosDeCosto)
                            CentrosCosto.Add(centro);
                    }

                    CentroSeleccionado = null;
                    OnPropertyChanged(nameof(CentrosCosto));
                    OnPropertyChanged(nameof(CentroSeleccionado));

                    _ = BuscarAsync();
                }
            }
        }

        private CentroDeCostoDTO? centroSeleccionado;
        public CentroDeCostoDTO? CentroSeleccionado
        {
            get => centroSeleccionado;
            set
            {
                if (centroSeleccionado != value)
                {
                    centroSeleccionado = value;
                    OnPropertyChanged();

                    // ✅ Verificamos que no sea null ni vacío para evitar limpiar Pickers por error
                    if (value?.Empresas != null && value.Empresas.Any())
                    {
                        Empresas.Clear();
                        foreach (var emp in value.Empresas)
                            Empresas.Add(emp);
                        OnPropertyChanged(nameof(Empresas));
                    }

                    _ = BuscarAsync();
                }
            }
        }


        private string? estatusSeleccionado = null;
        public string? EstatusSeleccionado
        {
            get => estatusSeleccionado;
            set
            {
                estatusSeleccionado = value;
                OnPropertyChanged();
                _ = BuscarAsync();
            }
        }

        private string filtroTexto = string.Empty;
        public string FiltroTexto
        {
            get => filtroTexto;
            set
            {
                filtroTexto = value;
                OnPropertyChanged();
            }
        }

        private async Task InicializarAsync()
        {
            try
            {
                await CargarDivisionesAsync();
                await BuscarAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al inicializar datos: {ex.Message}");
            }
        }

        private async Task CargarDivisionesAsync()
        {
            try
            {
                var service = new Services.Divisiones_CentrosDeCosto_Empresas.Divisiones_CentrosDeCosto_Empresas();
                var todas = await service.GetDivisionesAsync();

                if (todas != null)
                {
                    var activas = todas.Where(d => d.Activa).ToList();

                    // ✅ Solo limpiar si realmente hay cambios
                    if (activas.Count != Divisiones.Count || !activas.All(d => Divisiones.Any(x => x.Id == d.Id)))
                    {
                        Divisiones.Clear();
                        foreach (var div in activas)
                            Divisiones.Add(div);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar divisiones: {ex.Message}");
            }
        }

        public async Task BuscarAsync()
        {
            try
            {
                var empleados = await httpClient.GetFromJsonAsync<List<Empleado>>("api/Empleado");
                if (empleados == null) return;

                var filtrados = empleados.Where(e => e.Persona != null).ToList();

                if (!string.IsNullOrWhiteSpace(FiltroTexto))
                {
                    var texto = FiltroTexto.ToLower();
                    filtrados = filtrados.Where(e =>
                        (!string.IsNullOrWhiteSpace(e.Persona?.NombreCompleto) && e.Persona.NombreCompleto.ToLower().Contains(texto)) ||
                        (!string.IsNullOrWhiteSpace(e.Persona?.Curp) && e.Persona.Curp.ToLower().Contains(texto)) ||
                        (!string.IsNullOrWhiteSpace(e.Persona?.Rfc) && e.Persona.Rfc.ToLower().Contains(texto)) ||
                        (!string.IsNullOrWhiteSpace(e.NumeroEmpleado) && e.NumeroEmpleado.ToLower().Contains(texto))
                    ).ToList();
                }

                if (!string.IsNullOrWhiteSpace(EstatusSeleccionado))
                {
                    filtrados = filtrados.Where(e =>
                        e.EstatusEmpleado.ToString() == EstatusSeleccionado
                    ).ToList();
                }

                Empleados.Clear();
                foreach (var emp in filtrados)
                    Empleados.Add(emp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar empleados: {ex.Message}");
            }
        }
    }
}
