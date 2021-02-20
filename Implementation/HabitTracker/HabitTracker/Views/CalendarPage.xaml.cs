using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*
 * https//help.syncfusion.com/xamarin/calendar/getting-started?cs-save-lang=1&cs-lang=xaml
 * 
 * SyncFusion SfCalendar
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
            this.Content = calendar;

            // Sets Blackout Dates
            List<DateTime> black_dates = new List<DateTime>();
            for (int i = 0; i < 5; i++)
            {
                DateTime date = new DateTime(2021, 1, 1 + i);
                black_dates.Add(date);
            }
            calendar.BlackoutDates = black_dates;

            // Restricts Dates to Specified Range
            calendar.MinDate = new DateTime(2017, 1, 1);
            calendar.MaxDate = new DateTime(2021, 12, 31);
            this.Content = calendar;
        }
    }
}