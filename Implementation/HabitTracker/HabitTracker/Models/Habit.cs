﻿using HabitTracker.Database;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Models
{
    public class Habit : DBEntity
    {
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
        public int Recurrence_Frequency { get; set; }
        public int Reccurence_Period { get; set; }
        public DateTime Time_Alarm { get; set; }

        public Habit()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Habit).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Habit)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Habit>> GetHabitsAsync()
        {
            return Database.Table<Habit>().ToListAsync();
        }

        //public Task<List<Habit>> GetHabitsNotDoneAsync()
        //{
        //    // SQL queries are also possible
        //    return Database.QueryAsync<Habit>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        //}

        public Task<Habit> GetHabitAsync(int id)
        {
            return Database.Table<Habit>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveHabitAsync(Habit habit)
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

        public Task<int> DeleteHabitAsync(Habit habit)
        {
            return Database.DeleteAsync(habit);
        }
    }
}
