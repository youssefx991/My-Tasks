using Bogus;
using Day19.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationRunner.Fakers
{
    internal class AchievmentFaker : Faker<Achievement>
    {
        /*
         * 
          * public int Id { get; set; }
            public int PlayerId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; } 
            public int Points { get; set; } 
            public DateTime EarnedAt { get; set; }
         */

        public AchievmentFaker()
        {
            RuleFor(a => a.PlayerId, f => f.Random.Int(1, 10_000));
            RuleFor(a => a.Title, f => f.Lorem.Sentence(3));
            RuleFor(a => a.Description, f => f.Lorem.Paragraph());
            RuleFor(a => a.Points, f => f.Random.Int(10, 1000));
            RuleFor(a => a.EarnedAt, f => f.Date.Past(5));
        }
    }
}
