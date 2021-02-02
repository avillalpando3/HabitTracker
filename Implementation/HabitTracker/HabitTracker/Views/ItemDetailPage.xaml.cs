using HabitTracker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HabitTracker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}