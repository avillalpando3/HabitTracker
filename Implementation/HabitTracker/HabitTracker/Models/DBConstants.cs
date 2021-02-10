using SQLite;
using System;
using System.IO;

namespace HabitTracker.Models
{
    public static class DBConstants
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
                var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Database";
                return Path.Combine(basePath, DatabaseFilename);
            }
        }      
    }
}
