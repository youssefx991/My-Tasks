using Day19.Context;
using MigrationRunner.Fakers;

void SeedData()
{
    using BenchmarkContext context = new BenchmarkContext();
    var players = new PlayerFaker().Generate(10_000);
    var matchResults = new MatchResultFaker().Generate(10_000);
    var achievements = new AchievmentFaker().Generate(10_000);

    context.Players.AddRange(players);
    context.MatchResults.AddRange(matchResults);
    context.Achievements.AddRange(achievements);

    Console.WriteLine("Finished");
    Console.WriteLine(context.SaveChanges());
}

SeedData();