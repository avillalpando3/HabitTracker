using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*
 * https//download.microsoft.com/download/7/8/8/788971A6-C4BB-43CA-91DC-557B8BE72928/
 * Microsoft_Press_eBook_CreatingMobileAppswithXamarinForms_PDF.pdf
*/

namespace HabitTracker.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        void OnToolbarItemClicked(object sender, EventArgs args)
        {
            ToolbarItem toolbarItem = (ToolbarItem)sender;
            label.Text = "ToolbarItem '" + toolbarItem.Text + "' clicked";
        }
    }
}