using HabitTracker.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompletionLogTracker.Models
{
    public class CompletionLog
    {
        public int ID { get; set; }
        public int Habit_ID { get; set; }
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

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

        public Task<List<CompletionLog>> GetItemsAsync()
        {
            return Database.Table<CompletionLog>().ToListAsync();
        }

        public Task<List<CompletionLog>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<CompletionLog>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<CompletionLog> GetItemAsync(int id)
        {
            return Database.Table<CompletionLog>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(CompletionLog item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(CompletionLog item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
