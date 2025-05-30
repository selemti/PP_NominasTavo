using Microsoft.Maui.Controls;
using PP_Nominas.ViewModel.Catalogos.Empleados;
using System;

namespace PP_Nominas.Views.Catalogos.Empleados
{
    public partial class NuevoEmpleadoView : ContentPage
    {
        public NuevoEmpleadoView()
        {
            InitializeComponent();
            BindingContext = new NuevoEmpleadoViewModel();
        }

        private async void OnGuardarClicked(object sender, EventArgs e)
        {
            if (BindingContext is NuevoEmpleadoViewModel vm)
            {
                bool exito = await vm.GuardarAsync();

                await DisplayAlert(
                    exito ? "Éxito" : "Error",
                    exito ? "Empleado guardado correctamente." : "Verifica los datos ingresados.",
                    "OK");

                if (exito)
                    await Shell.Current.GoToAsync("..");
            }
        }


        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Confirmar", "¿Deseas cancelar?", "Sí", "No");
            if (confirm)
                await Shell.Current.GoToAsync("..");
        }

    }
}
