using Microsoft.Maui.Controls;
using PP_Nominas.Views.Catalogos.Empleados;

namespace PP_Nominas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(NuevoEmpleadoView), typeof(NuevoEmpleadoView));
            //Routing.RegisterRoute("NuevoEmpleadoView", typeof(NuevoEmpleadoView));
            Routing.RegisterRoute(nameof(NuevoEmpleadoView), typeof(NuevoEmpleadoView));
            Routing.RegisterRoute(nameof(DetalleEmpleadoView), typeof(DetalleEmpleadoView));
        }
    }
}
