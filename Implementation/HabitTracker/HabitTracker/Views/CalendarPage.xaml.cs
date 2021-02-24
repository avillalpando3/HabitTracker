using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*
 * SyncFusion HowTo located at bottom
 * 
 */

namespace HabitTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            Title = "Calendar";
            InitializeComponent();

            // Adds the SfCalendar Control
            SfCalendar calendar = new SfCalendar();
  
            // Restricts Dates to Specified Range
            calendar.MinDate = new DateTime(1990, 1, 1);
            calendar.MaxDate = new DateTime(2100, 12, 31);
            this.Content = calendar;

            // Sets Blackout Dates
            List<DateTime> black_dates = new List<DateTime>();
            for (int i = 0; i < 5; i++)
            {
                DateTime date = new DateTime(2021, 1, 1 + i);
                black_dates.Add(date);
            }
            calendar.BlackoutDates = black_dates;

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
    }
}

/*
 * Joshua Kidder
 * SyncFusion SfCalendar
 * https//help.syncfusion.com/xamarin/calendar/getting-started?cs-save-lang=1&cs-lang=xaml
 * 
 * OnCalendarTapped
 * https:www.syncfusion.com/kb/12281/how-to-get-the-tapped-appointment-details-in-xamarin-forms-calendar-sfcalendar
 */