using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Day19.Entities;
using System.Configuration;
namespace Day19.Context
{
    public class BenchmarkContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<MatchResult> MatchResults { get; set; }
        public DbSet<Achievement> Achievements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["GameConnection"].ConnectionString);
        
    }
}
