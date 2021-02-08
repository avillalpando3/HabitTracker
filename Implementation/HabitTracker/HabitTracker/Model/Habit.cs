using SQLite;
using System;

namespace HabitTracker.Models
{

    public class Habit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
        public int Recurrence_Frequency { get; set; }
        public int Reccurence_Period { get; set; }
        public DateTime Time_Alarm { get; set; }
    }
}