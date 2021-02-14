using SQLite;
using System;
using System.IO;

namespace HabitTracker.DAL
{
    static class DBConstants
    {

        // Database connection definition
        private const string DatabaseFilename = "HabitTracker.db";
        private static string basePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Database";
        private static string DatabasePath = Path.Combine(basePath, DatabaseFilename);

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DatabasePath, Flags);
        });
        internal static SQLiteAsyncConnection database => lazyInitializer.Value;
        // End database connection definition

        internal const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

    }
}
