using HabitTracker.DAL;
using HabitTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HabitTracker.ViewModels
{
    public class NewHabitViewModel : BaseViewModel
    {
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private int sortPrecedence;
        public int SortPrecedence
        {
            get => sortPrecedence;
            set => SetProperty(ref sortPrecedence, value);
        }

        private string color;
        public string Color
        {
            get => color;
            set => SetProperty(ref color, value);
        }

        private int recurrence_Frequency;
        public int Recurrence_Frequency
        {
            get => recurrence_Frequency;
            set => SetProperty(ref recurrence_Frequency, value);
        }

        private int reccurence_Period;
        public int Reccurence_Period
        {
            get => reccurence_Period;
            set => SetProperty(ref reccurence_Period, value);
        }

        private DateTime time_Alarm;
        public DateTime Time_Alarm
        {
            get => time_Alarm;
            set => SetProperty(ref time_Alarm, value);
        }

        public Habit_DAL DataStore => DependencyService.Get<Habit_DAL>();

        public NewHabitViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(color);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            var habit = new Habit();

            await DataStore.SaveHabitAsync(habit);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
