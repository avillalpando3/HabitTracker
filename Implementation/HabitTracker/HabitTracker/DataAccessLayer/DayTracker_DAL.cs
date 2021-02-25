using HabitTracker.Common;
using HabitTracker.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace HabitTracker.DAL
{
    public class DayTracker_DAL
    {

        public DayTracker_DAL()
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

        private int dayCounter;

        private TimeSpan incrementTime;

        private void incrementDay()
        {
            // TODO implement here
        }

        public void getDay()
        {
            // TODO implement here
        }

    }
}