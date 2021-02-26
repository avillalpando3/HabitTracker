using HabitTracker.DAL;
using HabitTracker.Models;
using HabitTracker.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HabitTracker.ViewModels
{
    public class HabitsViewModel : BaseViewModel
    {
        private Habit _selectedHabit;

        public ObservableCollection<Habit> Habits { get; }
        public Command LoadHabitsCommand { get; }
        public Command AddHabitCommand { get; }
        public Command<Habit> HabitTapped { get; }
        public Command<Habit> HabitSwiped { get; }
        public Habit_DAL HabitTable => DependencyService.Get<Habit_DAL>();

        public HabitsViewModel()
        {
            Title = "Habits";
            Habits = new ObservableCollection<Habit>();
            LoadHabitsCommand = new Command(async () => await ExecuteLoadHabitsCommand());

            HabitTapped = new Command<Habit>(OnHabitSelected);

            HabitSwiped = new Command<Habit>(OnSwiped);

            AddHabitCommand = new Command(OnAddHabit);
        }

        async Task ExecuteLoadHabitsCommand()
        {
            IsBusy = true;

            try
            {
                Habits.Clear();
                var habits = await HabitTable.GetHabitsAsync();
                foreach (var habit in habits)
                {
                    Habits.Add(habit);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedHabit = null;
        }

        public Habit SelectedHabit
        {
            get => _selectedHabit;
            set
            {
                SetProperty(ref _selectedHabit, value);
                OnHabitSelected(value);
            }
        }

        private async void OnAddHabit(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewHabitPage));
        }

        async void OnHabitSelected(Habit Habit)
        {
            if (Habit == null)
                return;

            // This will push the HabitDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(HabitDetailPage)}?{nameof(HabitDetailViewModel.HabitId)}={Habit.Id}");
        }

        async void OnSwiped(Habit habit)
        {
            var id = habit.ID;
            HabitTable.DeleteHabitAsync(habit);
        }
    }
}