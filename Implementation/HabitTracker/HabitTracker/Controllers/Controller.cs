using HabitTracker.Models;
using SQLite;
using System;
using System.IO;

namespace HabitTracker.Controllers
{
    public class Controller
    {
        public Controller()
        {
            if (!File.Exists(DBConstants.DatabasePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DBConstants.DatabasePath));                
            }
            _database = new SQLiteAsyncConnection(DBConstants.DatabasePath);
        }

        protected static SQLiteAsyncConnection _database;
        protected static bool initialized = false;

        /// <summary>
        /// @param id
        /// </summary>
        // public abstract void delete(int id);

        /// <summary>
        /// @param query
        /// </summary>
        internal void customQuery(String query)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param resourceLocator
        /// </summary>
        internal void restoreFromBackup(String resourceLocator)
        {
            // TODO implement here
        }

        internal void exportToBackup()
        {
            // TODO implement here
        }

        internal void exportToCSV()
        {
            // TODO implement here
        }
    }
}
