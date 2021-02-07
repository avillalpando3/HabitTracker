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

        /// <summary>
        /// @param groupId 
        /// @param name 
        /// @param frequency 
        /// @param period 
        /// @param id_group 
        /// @param sortPrecedence 
        /// @param color 
        /// @param alarm
        /// </summary>
        public void create(int groupId, string name, int frequency, int period, int id_group, int sortPrecedence, String color, Time alarm)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void delete(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param day
        /// </summary>
        public void markComplete(int id, int day)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param day
        /// </summary>
        public void markIncomplete(int id, int day)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param day
        /// </summary>
        public void getCompletionStatus(HashSet<int> id, HashSet<int> day)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param frequency 
        /// @param periodLength
        /// </summary>
        public void setReccurence(int id, int frequency, int periodLength)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getReccurence(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public List getListDueToday()
        {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @param id 
        /// @param color
        /// </summary>
        public void setColor(int id, String color)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getColor(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param name
        /// </summary>
        public void setName(int id, String name)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getName(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param id_group
        /// </summary>
        public void moveToGroup(int id, int id_group)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void removeGrouping(int id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param time
        /// </summary>
        public void setAlarm(int id, Time time)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getAlarm(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void createSystemAlarm(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public List<int> listHabits()
        {
            // TODO implement here
            return null;
        }
    }
}
