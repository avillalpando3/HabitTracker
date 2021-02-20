using HabitTracker.Services;
using HabitTracker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabitTracker
{
    public partial class App : Application
    {

        public App()
        {
            // Registered Syncfusion License belonging to kiddjsh(Joshua Kidder)
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDAxOTcwQDMxMzgyZTM0MmUzMG4wWnVEMkIwRWsrdkxJb3o1ZmNFV3ZoZ3ovU0xBN0NSdm43M0J3QWpYclU9");

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
