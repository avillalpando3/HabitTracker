using HabitTracker.Models;
using HabitTracker.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.DAL
{
    public class CompletionLog_DAL : BaseDAL
    {
    
        public CompletionLog_DAL(): base()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync() // not sure where this goes
        {
            if (!initialized)
            {
                if (!_database.TableMappings.Any(m => m.MappedType.Name == typeof(CompletionLog).Name))
                {
                    await _database.CreateTablesAsync(CreateFlags.None, typeof(CompletionLog)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<CompletionLog>> GetCompletionLogsAsync()
        {
            return _database.Table<CompletionLog>().ToListAsync();
        }

        public Task<CompletionLog> GetCompletionLogAsync(int id)
        {
            return _database.Table<CompletionLog>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveCompletionLogAsync(CompletionLog completionLog)
        {
            if (completionLog.ID != 0)
            {
                return _database.UpdateAsync(completionLog);
            }
            else
            {
                return _database.InsertAsync(completionLog);
            }
        }

        public Task<int> DeleteCompletionLogAsync(CompletionLog completionLog)
        {
            return _database.DeleteAsync(completionLog);
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
