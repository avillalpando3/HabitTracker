using System;
using SQLite;

namespace HabitTracker.Models
{
    public class CompletionLog
    {
        public int ID { get; set; }
        public int Habit_ID { get; set; }
        public int Tracked_Day { get; set; }
        public DateTime DateTime_Completed { get; set; }

    }
}