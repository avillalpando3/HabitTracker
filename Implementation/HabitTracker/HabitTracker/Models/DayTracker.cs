using System;
using SQLite;

namespace HabitTracker.Models
{
    [Table("DayTracker")]
    class DayTracker
    {
        [PrimaryKey]
        public int ID { get; set; }
        public int dayCounter { get; set; }
        public DateTime incrementTime { get; set; }
    }
}
