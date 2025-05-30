using System;
using Microsoft.Maui.Controls;
using PP_Nominas.ViewModel.Catalogos.Empleados;
using PP_Nominas.Views.Catalogos.Empleados;
using PP_Nominas.Models.Catalogos.Shared;

namespace PP_Nominas.Views.Catalogos.Empleados;

/// <summary>Página para mostrar el listado de empleados y aplicar filtros.</summary>
public partial class EmpleadoPage : ContentPage
{
    private readonly EmpleadoPageViewModel viewModel;

    /// <summary>Inicializa la vista y su contexto de datos.</summary>
    public EmpleadoPage()
    {
        InitializeComponent();
        viewModel = new EmpleadoPageViewModel();
        BindingContext = viewModel;
    }

    /// <summary>
    /// Maneja el evento del botón de toolbar "Nuevo".
    /// Navega hacia la vista de alta de un nuevo empleado.
    /// </summary>
    private async void OnNuevoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NuevoEmpleadoView));
    }

    /// <summary>
    /// Maneja el clic en botón "Ver" para navegar al detalle del empleado seleccionado.
    /// </summary>
    private async void OnVerDetallesClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string empleadoId)
        {
            await Shell.Current.GoToAsync($"{nameof(DetalleEmpleadoView)}?empleadoId={empleadoId}");
        }
    }
}
