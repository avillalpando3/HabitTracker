using HabitTracker.Models;
using HabitTracker.ViewModels;
using Xamarin.Forms;

namespace HabitTracker.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}