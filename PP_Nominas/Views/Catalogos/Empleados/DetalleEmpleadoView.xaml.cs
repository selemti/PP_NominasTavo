using System;
using Microsoft.Maui.Controls;
using PP_Nominas.ViewModel.Catalogos.Empleados;

namespace PP_Nominas.Views.Catalogos.Empleados
{
    public partial class DetalleEmpleadoView : ContentPage
    {
        private readonly DetalleEmpleadoViewModel viewModel;

        public DetalleEmpleadoView()
        {
            InitializeComponent();
            viewModel = new DetalleEmpleadoViewModel();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.CargarEmpleadoAsync();
        }
    }
}
