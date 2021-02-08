using HabitTracker.Models;
using SQLite;
using System;

namespace HabitTracker.Controllers
{
    public class Controller
    {
        protected static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DBConstants.DatabasePath, DBConstants.Flags);
        });

        protected static SQLiteAsyncConnection Database => lazyInitializer.Value;
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
