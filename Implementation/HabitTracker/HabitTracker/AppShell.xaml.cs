using HabitTracker.ViewModels;
using HabitTracker.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HabitTracker
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewHabitPage), typeof(NewHabitPage));
        }
    }
}
