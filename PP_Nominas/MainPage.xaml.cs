using PP_Nominas.ViewModels;

namespace PP_Nominas
{
    public partial class MainPage : ContentPage
    {
        public MainPage(DashboardViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;

            // Configurar nombre de usuario real
            if (BindingContext is DashboardViewModel vm)
            {
                vm.UserName = "Administrador";
            }
        }
        private async void OnEmpleadosClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///EmpleadoPage");
        }

    }
}