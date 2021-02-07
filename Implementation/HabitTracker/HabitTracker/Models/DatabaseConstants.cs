using SQLite;
using System;
using System.IO;

namespace HabitTracker.Models
{
    public class DatabaseConstants
    {
        public const string DatabaseFilename = "HabitTracker.db";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Database";
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        public static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
        });        
    }
}
