using HabitTracker.DAL;
using HabitTracker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabitTracker
{
    public partial class App : Application
    {
        //static BaseDataAccessLayer databaseController;

        //public static BaseDataAccessLayer Controller
        //{
        //    get
        //    {
        //        if (databaseController == null)
        //        {
        //            databaseController = new BaseDataAccessLayer();
        //        }
        //        return databaseController;
        //    }
        //}

        public App()
        {
            InitializeComponent();

            var habit_dal = new Habit_DAL();
            DependencyService.RegisterSingleton<Habit_DAL>(habit_dal);

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
