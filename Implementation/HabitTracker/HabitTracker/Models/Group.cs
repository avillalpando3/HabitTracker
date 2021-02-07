using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Models
{
    public class Group
    {
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public Group()
        {
            InitializeAsync().Start();
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Group).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Group)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Group>> GetItemsAsync()
        {
            return Database.Table<Group>().ToListAsync();
        }

        public Task<List<Group>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<Group>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Group> GetItemAsync(int id)
        {
            return Database.Table<Group>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Group item)
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

        public Task<int> DeleteItemAsync(Group item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
