using HabitTracker.Models;
using HabitTracker.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.DAL
{
    public class CompletionLog_DAL : StorageFile_DAL
    {
    
        public CompletionLog_DAL(): base()
        {
            InitializeAsync().Start();
        }

        private static bool initialized = false;
        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!DBConstants.Database.TableMappings.Any(m => m.MappedType.Name == typeof(CompletionLog).Name))
                {
                    await DBConstants.Database.CreateTablesAsync(CreateFlags.None, typeof(CompletionLog)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<CompletionLog>> GetCompletionLogsAsync()
        {
            return DBConstants.Database.Table<CompletionLog>().ToListAsync();
        }

        public Task<CompletionLog> GetCompletionLogAsync(int id)
        {
            return DBConstants.Database.Table<CompletionLog>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveCompletionLogAsync(CompletionLog completionLog)
        {
            if (completionLog.ID != 0)
            {
                return DBConstants.Database.UpdateAsync(completionLog);
            }
            else
            {
                return DBConstants.Database.InsertAsync(completionLog);
            }
        }

        public Task<int> DeleteCompletionLogAsync(CompletionLog completionLog)
        {
            return DBConstants.Database.DeleteAsync(completionLog);
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
