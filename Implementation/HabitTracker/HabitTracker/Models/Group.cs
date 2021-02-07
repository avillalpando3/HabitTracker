using HabitTracker.Common;
using HabitTracker.Database;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Models
{
    public class Group: DBEntity
    {
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }

        public Group()
        {
            InitializeAsync().SafeFireAndForget(false);
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

        public Task<List<Group>> GetGroupsAsync()
        {
            return Database.Table<Group>().ToListAsync();
        }

        public Task<Group> GetGroupAsync(int id)
        {
            return Database.Table<Group>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveGroupAsync(Group group)
        {
            if (group.ID != 0)
            {
                return Database.UpdateAsync(group);
            }
            else
            {
                return Database.InsertAsync(group);
            }
        }

        public Task<int> DeleteGroupAsync(Group group)
        {
            return Database.DeleteAsync(group);
        }
    }
}
