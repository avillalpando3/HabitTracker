using Syncfusion.SfCalendar.XForms;
using System;
using Xamarin.Forms;

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

            // Adds the SfCalendar Control
            SfCalendar calendar = new SfCalendar();

            // Restricts Dates to Specified Range
            calendar.MinDate = new DateTime(1990, 1, 1);
            calendar.MaxDate = new DateTime(2100, 12, 31);

            // Shows the first row of month view dates
            calendar.NumberOfWeeksInView = 1;
            //calendar.HeightRequest = 50;
            this.Content = calendar;
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
 * 
 * https//help.syncfusion.com/xamarin/calendar/display-modes#week-view
 * Week View
*/