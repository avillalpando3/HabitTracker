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

            // Adds the SfCalendar Control
            SfCalendar calendar = new SfCalendar();

            // Shows the first row of month view dates
            calendar.NumberOfWeeksInView = 1;

            // Restricts dates to specified range
            calendar.MinDate = new DateTime(1990, 1, 1);
            calendar.MaxDate = new DateTime(2100, 12, 31);
            this.Content = calendar;

            // Gets appointment details in OnCalendarTapped event
            calendar.OnCalendarTapped += Calendar_OnCalendarTapped;

            void Calendar_OnCalendarTapped(object sender, CalendarTappedEventArgs e)
            {
                var appointmentCollection = e.SelectedAppointment as CalendarEventCollection;
                if (appointmentCollection.Count > 0)
                {
                    var appointment = appointmentCollection[0]; ;
                    App.Current.MainPage.DisplayAlert(appointment.Subject, appointment.StartTime.ToString("dd/MM/yyyy hh:mm tt"), "OK");
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("", "No Events", "OK");
                }
            }
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