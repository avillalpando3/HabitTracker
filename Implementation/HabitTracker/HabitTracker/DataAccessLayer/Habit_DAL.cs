using HabitTracker.Common;
using HabitTracker.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.DAL
{
    public class Habit_DAL
    {
        public Habit_DAL() : base()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        private static bool initialized = false;
        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!DBConstants.Database.TableMappings.Any(m => m.MappedType.Name == typeof(Habit).Name))
                {
                    await DBConstants.Database.CreateTablesAsync(CreateFlags.None, typeof(Habit)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }
        
        public Task<List<Habit>> GetHabitsAsync()
        {
            return DBConstants.Database.Table<Habit>().ToListAsync();
        }

        public Task<Habit> GetDataAsync(int id)
        {
            return DBConstants.Database.Table<Habit>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveHabitAsync(Habit habit)
        {
            if (habit.ID != 0)
            {
                return DBConstants.Database.UpdateAsync(habit);
            }
            else
            {
                return DBConstants.Database.InsertAsync(habit);
            }
        }

        public Task<int> DeleteHabitAsync(Habit habit)
        {
            return DBConstants.Database.DeleteAsync(habit);
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
        public Task<List<Habit>> getListDueToday()
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
        public void setAlarm(int id, TimeSpan time)
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
