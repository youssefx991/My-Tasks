using System;

namespace Day19.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public int Points { get; set; } 
        public DateTime EarnedAt { get; set; }
    }
}