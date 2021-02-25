using SQLite;
using System;
using System.IO;

namespace HabitTracker.DAL
{
    static class DBConstants
    {

        private static readonly object padlock = new object();
        static SQLiteAsyncConnection database;
        internal static SQLiteAsyncConnection Database
        {
            get
            {
                lock (padlock)
                {
                    if (database == null)
                    {
                        database = new SQLiteAsyncConnection(DatabasePath);
                    }
                    return database;
                }
            }
        }

        internal const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        private const string DatabaseFilename = "HabitTracker.db";
        internal static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

    }
}
