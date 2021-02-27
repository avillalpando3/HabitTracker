using HabitTracker.Services;
using Xamarin.Forms;

namespace HabitTracker
{
    public partial class App : Application
    {

        public App()
        {
            // Registered Syncfusion License
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
