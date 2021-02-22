using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Syncfusion.SfCalendar.XForms;

/*
 * CreatingMobileAppswithXamarinForms notes at bottom
 * 
*/

namespace HabitTracker.Views
{  
    public partial class AboutPage : ContentPage
    {
        
        public AboutPage()
        {
            InitializeComponent();
        }

        //  Displays the text of the ToolbarItem
        async void OnToolbarItemClicked(object sender, EventArgs args)
        {
            ToolbarItem toolbarItem = (ToolbarItem)sender;
            label.Text = "ToolbarItem '" + toolbarItem.Text + "' clicked";

            // Navigate to CalendarPage
            await Navigation.PushAsync(new CalendarPage());
        }
    }
}

/*
 * Joshua Kidder
 * https//download.microsoft.com/download/7/8/8/788971A6-C4BB-43CA-91DC-557B8BE72928/
 * Microsoft_Press_eBook_CreatingMobileAppswithXamarinForms_PDF.pdf
 * 
 * Pg 333: ToolBarItem
 * Pg 920: Page Navigation
*/