using HabitTracker.Common;
using HabitTracker.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.Controllers
{
    public class Group_Controller : Controller
    {

        public Group_Controller()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync() // not sure where this goes
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

        /// <summary>
        /// @param name 
        /// @param id_group 
        /// @param sortPrecedence 
        /// @param color
        /// </summary>
        public void create(string name, int id_group, int sortPrecedence, string color)
        {
            // TODO implement here
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
