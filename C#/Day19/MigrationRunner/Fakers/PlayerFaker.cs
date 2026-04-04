using Bogus;
using Day19.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationRunner.Fakers
{
    internal class PlayerFaker : Faker<Player>
    {
        /*
          * public int Id { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Region { get; set; } // e.g., "EUW", "NA", "EUNE"
            public DateTime JoinDate { get; set; }
            public bool IsSubscribed { get; set; }
         * 
         */

        public PlayerFaker()
        {
            RuleFor(p => p.Username, f => f.Internet.UserName());
            RuleFor(p => p.Email, f => f.Internet.Email());
            RuleFor(p => p.Region, f => f.PickRandom(new[] { "EUW", "NA", "EUNE", "KR", "JP" }));
            RuleFor(p => p.JoinDate, f => f.Date.Past(5)); 
            RuleFor(p => p.IsSubscribed, f => f.Random.Bool()); 
        }
    }
}
