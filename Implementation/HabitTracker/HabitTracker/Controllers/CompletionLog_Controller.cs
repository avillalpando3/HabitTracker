using HabitTracker.Models;
using HabitTracker.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Controllers
{
    public class CompletionLog_Controller : Controller
    {
    
        public CompletionLog_Controller()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync() // not sure where this goes
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

        public Task<CompletionLog_Controller> GetCompletionLogAsync(int id)
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
