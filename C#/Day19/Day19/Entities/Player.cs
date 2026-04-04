using System;

namespace Day19.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsSubscribed { get; set; }
    }
}