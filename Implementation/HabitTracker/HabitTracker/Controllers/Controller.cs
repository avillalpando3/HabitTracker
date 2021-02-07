using HabitTracker.Database;
using SQLite;
using System;

namespace HabitTracker.Models
{
    public class Controller
    {
        protected static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DBConstants.DatabasePath, DBConstants.Flags);
        });

        protected static SQLiteAsyncConnection Database => lazyInitializer.Value;
        protected static bool initialized = false;        
    }
}
