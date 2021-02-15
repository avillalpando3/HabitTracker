using HabitTracker.Models;
using HabitTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HabitTracker.Views
{
    public partial class NewHabitPage : ContentPage
    {
        public Item Item { get; set; }

        public NewHabitPage()
        {
            InitializeComponent();
            BindingContext = new NewHabitViewModel();
        }
    }
}