
namespace Day19.Entities
{
    public class MatchResult
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string GameTitle { get; set; } 
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public long Score { get; set; }
        public int DurationSeconds { get; set; }
        public bool IsWinner { get; set; }
    }
}