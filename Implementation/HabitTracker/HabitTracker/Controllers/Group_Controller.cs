using HabitTracker.Common;
using HabitTracker.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Controllers
{
    public class Group_Controller: Controller
    {
        
        public Group_Controller() : base()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync() // not sure where this goes
        {
            if (!initialized)
            {
                if (!_database.TableMappings.Any(m => m.MappedType.Name == typeof(Group).Name))
                {
                    await _database.CreateTablesAsync(CreateFlags.None, typeof(Group)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Group>> GetGroupsAsync()
        {
            return _database.Table<Group>().ToListAsync();
        }

        public Task<Group> GetGroupAsync(int id)
        {
            return _database.Table<Group>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveGroupAsync(Group group)
        {
            if (group.ID != 0)
            {
                return _database.UpdateAsync(group);
            }
            else
            {
                return _database.InsertAsync(group);
            }
        }
        public Task<int> DeleteGroupAsync(Group group)
        {
            return _database.DeleteAsync(group);
        }

        /// <summary>
        /// @param name 
        /// @param id_group 
        /// @param sortPrecedence 
        /// @param color
        /// </summary>
        public Task<int> Create(Group group)
        {
            return _database.InsertAsync(group);
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void delete(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getColor(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getName(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void getPrecedence(HashSet<int> id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param id_group
        /// </summary>
        public void moveToGroup(int id, int id_group)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id
        /// </summary>
        public void removeGrouping(int id)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param color
        /// </summary>
        public void setColor(int id, string color)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param name
        /// </summary>
        public void setName(int id, string name)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param id 
        /// @param precedence
        /// </summary>
        public void setPrecedence(int id, int precedence)
        {
            // TODO implement here
        }
    }
}
