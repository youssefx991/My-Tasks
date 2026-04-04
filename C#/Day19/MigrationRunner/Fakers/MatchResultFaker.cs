using Bogus;
using Day19.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationRunner.Fakers
{
    internal class MatchResultFaker : Faker<MatchResult>
    {
        /*
          * public int Id { get; set; }
            public int PlayerId { get; set; }
            public string GameTitle { get; set; } 
            public int Kills { get; set; }
            public int Deaths { get; set; }
            public int Assists { get; set; }
            public long Score { get; set; }
            public int DurationSeconds { get; set; }
            public bool IsWinner { get; set; }
         */

        // i will insert 10_000 players
        public MatchResultFaker()
        {
            RuleFor(m=>m.PlayerId, f => f.Random.Int(1, 10_000));
            RuleFor(m=>m.GameTitle, f => f.PickRandom(new[] { "League of Legends", "Valorant", "Fortnite", "Apex Legends", "Call of Duty" }));
            RuleFor(m=>m.Kills, f => f.Random.Int(0, 50));
            RuleFor(m=>m.Deaths, f => f.Random.Int(0, 50));
            RuleFor(m=>m.Assists, f => f.Random.Int(0, 50));
            RuleFor(m=>m.Score, f => f.Random.Long(0, 100_000));
            RuleFor(m=>m.DurationSeconds, f => f.Random.Int(300, 3600));
            RuleFor(m=>m.IsWinner, f => f.Random.Bool());
        }
    }
}
