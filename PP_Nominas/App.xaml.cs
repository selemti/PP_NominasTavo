using Syncfusion.Licensing;
namespace PP_Nominas
{
    public partial class App : Application
    {
        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXpfdHVcQ2dcVEFzXEpWYUA=");
            InitializeComponent();
        }
        public string PP_FinanzasURL = "https://pp.gawa.mx/";
#if DEBUG
        public static string BackURLBaseAddress = "https://localhost:44380/";
#elif RELEASE
        public static string BackURLBaseAddress = "https://nominas.gawa.mx/";
#endif

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}