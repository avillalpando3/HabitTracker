using HabitTracker.Common;
using HabitTracker.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitTracker.DAL
{
    public class Group_DAL
    {
        
        public Group_DAL()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        private static bool initialized = false;
        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!DBConstants.Database.TableMappings.Any(m => m.MappedType.Name == typeof(Group).Name))
                {
                    await DBConstants.Database.CreateTablesAsync(CreateFlags.None, typeof(Group)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Group>> GetGroupsAsync()
        {
            return DBConstants.Database.Table<Group>().ToListAsync();
        }

        public Task<Group> GetGroupAsync(int id)
        {
            return DBConstants.Database.Table<Group>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveGroupAsync(Group group)
        {
            if (group.ID != 0)
            {
                return DBConstants.Database.UpdateAsync(group);
            }
            else
            {
                return DBConstants.Database.InsertAsync(group);
            }
        }
        public Task<int> DeleteGroupAsync(Group group)
        {
            return DBConstants.Database.DeleteAsync(group);
        }

        /// <summary>
        /// @param name 
        /// @param id_group 
        /// @param sortPrecedence 
        /// @param color
        /// </summary>
        public Task<int> Create(Group group)
        {
            return DBConstants.Database.InsertAsync(group);
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
