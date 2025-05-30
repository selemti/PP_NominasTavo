using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Layouts;
using PP_Nominas.ViewModels;
using PP_Nominas.Services;
using PP_Nominas.Services.Catalogos.Empleados;
using Syncfusion.Maui.Core.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using PP_Nominas.Services.Divisiones_CentrosDeCosto_Empresas;

namespace PP_Nominas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FAS");
                    fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FAR");
                    fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FAB");
                });

#if DEBUG
            builder.Logging.AddDebug();
            builder.Logging.SetMinimumLevel(LogLevel.Trace); // COMENTAR EN PRODUCCIÓN
#endif

            // 🔐 Registro de ViewModels y servicios UI
            builder.Services.AddSingleton<DashboardViewModel>();
            builder.Services.AddSingleton<MainPage>();

            // 📦 Servicios de negocio
            builder.Services.AddHttpClient<EmpleadoService>(client => { client.BaseAddress = new Uri(App.BackURLBaseAddress);});
            builder.Services.AddSingleton<OrganigramaService>();
            builder.Services.AddSingleton<TipoContratoService>();
            builder.Services.AddSingleton<Divisiones_CentrosDeCosto_Empresas>();

            // 🌐 HttpClient con base dinámica desde App.xaml.cs
            builder.Services.AddHttpClient("DefaultClient", client =>
            {
                client.BaseAddress = new Uri(App.BackURLBaseAddress);
            });

            return builder.Build();
        }
    }
}
