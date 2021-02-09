using SQLite;
using System;

namespace HabitTracker.Models
{
    [Table("Habits")]
    public class Habit
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [/*ForeignKey*/ Indexed]
        public int Group_ID { get; set; }
        //[NotNull
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
        //[NotNull]
        public int Recurrence_Frequency { get; set; }
        //[NotNull]
        public int Reccurence_Period { get; set; }
        public DateTime Time_Alarm { get; set; }
    }
}