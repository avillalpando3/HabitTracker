using HabitTracker.Common;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Database
{
    public class DBEntity
    {
        protected static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DBConstants.DatabasePath, DBConstants.Flags);
        });

        protected static SQLiteAsyncConnection Database => lazyInitializer.Value;
        protected static bool initialized = false;        
    }
}
