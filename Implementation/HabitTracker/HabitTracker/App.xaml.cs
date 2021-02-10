using HabitTracker.Services;
using HabitTracker.Controllers;
using HabitTracker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabitTracker
{
    public partial class App : Application
    {
        static Controller databaseController;

        public static Controller Controller
        {
            get
            {
                if (databaseController == null)
                {
                    databaseController = new Controller();
                }
                return databaseController;
            }
        }

        public App()
        {
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
