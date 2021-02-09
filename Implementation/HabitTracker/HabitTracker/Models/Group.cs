using System;
using SQLite;

namespace HabitTracker.Models
{
    [Table("Groups")]
    public class Group
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [/*ForeignKey*/ Indexed]
        public int Group_ID { get; set; }
        //[NotNull]
        public string Name { get; set; }
        public int SortPrecedence { get; set; }
        public string Color { get; set; }
    }
}