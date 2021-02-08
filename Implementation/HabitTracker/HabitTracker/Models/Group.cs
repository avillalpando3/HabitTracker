using System;
using SQLite;

namespace HabitTracker.Models
{
    public class Group
    {
        public int ID { get; set; }
        public int Group_ID { get; set; }
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
    }
}