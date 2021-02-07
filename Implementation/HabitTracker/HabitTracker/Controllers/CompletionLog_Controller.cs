using HabitTracker.Database;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Controllers
{
    public class CompletionLog_Controller : DBEntity
    {
        public int ID { get; set; }
        public int Habit_ID { get; set; }
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

        public CompletionLog_Controller()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(CompletionLog_Controller).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(CompletionLog_Controller)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<CompletionLog_Controller>> GetCompletionLogsAsync()
        {
            return Database.Table<CompletionLog_Controller>().ToListAsync();
        }

        public Task<CompletionLog_Controller> GetCompletionLogAsync(int id)
        {
            return Database.Table<CompletionLog_Controller>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveCompletionLogAsync(CompletionLog_Controller completionLog)
        {
            if (completionLog.ID != 0)
            {
                return Database.UpdateAsync(completionLog);
            }
            else
            {
                return Database.InsertAsync(completionLog);
            }
        }

        public Task<int> DeleteCompletionLogAsync(CompletionLog_Controller completionLog)
        {
            return Database.DeleteAsync(completionLog);
        }

        /// <summary>
        /// @param id_habit
        /// </summary>
        public void create(int id_habit)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id_habit
        /// </summary>
        public void delete(HashSet<int> id_habit)
        {
            // TODO implement here
        }
    }
}
