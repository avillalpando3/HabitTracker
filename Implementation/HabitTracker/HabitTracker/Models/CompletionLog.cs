using System;
using SQLite;

namespace HabitTracker.Models
{
    [Table("CompletionLogs")]
    public class CompletionLog
    {
        [PrimaryKey]
        public int Habit_ID { get; set; }
        [PrimaryKey]
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

    }
}