using HabitTracker.Database;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Models
{
    public class Habit_Controller : Controller
    {
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
        public int Recurrence_Frequency { get; set; }
        public int Reccurence_Period { get; set; }
        public DateTime Time_Alarm { get; set; }

        public Habit_Controller()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Habit_Controller).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Habit_Controller)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Habit_Controller>> GetHabitsAsync()
        {
            return Database.Table<Habit_Controller>().ToListAsync();
        }

        public Task<Habit_Controller> GetHabitAsync(int id)
        {
            return Database.Table<Habit_Controller>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveHabitAsync(Habit_Controller habit)
        {
            if (habit.ID != 0)
            {
                return Database.UpdateAsync(habit);
            }
            else
            {
                return Database.InsertAsync(habit);
            }
        }

        public Task<int> DeleteHabitAsync(Habit_Controller habit)
        {
            return Database.DeleteAsync(habit);
        }
    }
}
