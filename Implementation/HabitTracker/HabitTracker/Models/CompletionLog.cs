using HabitTracker.Database;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompletionLogTracker.Models
{
    public class CompletionLog : DBEntity
    {
        public int ID { get; set; }
        public int Habit_ID { get; set; }
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

        public CompletionLog()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(CompletionLog).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(CompletionLog)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<CompletionLog>> GetCompletionLogsAsync()
        {
            return Database.Table<CompletionLog>().ToListAsync();
        }

        public Task<CompletionLog> GetCompletionLogAsync(int id)
        {
            return Database.Table<CompletionLog>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveCompletionLogAsync(CompletionLog completionLog)
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

        public Task<int> DeleteCompletionLogAsync(CompletionLog completionLog)
        {
            return Database.DeleteAsync(completionLog);
        }
    }
}
