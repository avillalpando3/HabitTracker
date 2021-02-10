using System;
using SQLite;

namespace HabitTracker.Models
{
    [Table("CompletionLogs")]
    public class CompletionLog
    {
        [PrimaryKey]
        public int ID { get; set; }
        public int Habit_ID { get; set; }
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

    }
}