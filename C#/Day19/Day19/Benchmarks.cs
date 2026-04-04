using BenchmarkDotNet.Attributes;
using Dapper;
using Day19.Context;
using Day19.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VSDiagnostics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
namespace Day19
{
    // For more information on the VS BenchmarkDotNet Diagnosers see https://learn.microsoft.com/visualstudio/profiling/profiling-with-benchmark-dotnet
    [CPUUsageDiagnoser]
    public class Benchmarks
    {
        string connectionString = ConfigurationManager.ConnectionStrings["GameConnection"].ConnectionString;
        BenchmarkContext context;
        SqlConnection connection;

        [GlobalSetup]
        public void Setup()
        {
            context = new BenchmarkContext();
            connection = new SqlConnection(connectionString);
            connection.Open();

            connection.Execute("Select 1");
        }

 

        [Benchmark]
        public List<Player> GetAll_ADO()
        {
            var list = new List<Player>();
            using var cmd = new SqlCommand("SELECT * FROM Players", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Player { 
                    Id = (int)reader["Id"], 
                    Username = reader["Username"].ToString(),
                    Email = reader["Email"].ToString(),
                    Region = reader["Region"].ToString(),
                    IsSubscribed = reader["IsSubscribed"] is bool b ? b : false,
                    JoinDate = reader["JoinDate"] is DateTime dt ? dt : DateTime.MinValue
                });
            }
            return list;
        }

        [Benchmark]
        public List<Player> GetAll_Dapper() => connection.Query<Player>("SELECT * FROM Players").ToList();

        [Benchmark]
        public List<Player> GetAll_EF() => context.Players.ToList();



        [Benchmark]
        public List<Player> Where_ADO()
        {
            var list = new List<Player>();
            using var cmd = new SqlCommand("SELECT * FROM Players WHERE Region = 'EUW'", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                list.Add(new Player
                {
                    Id = (int)reader["Id"],
                    Username = reader["Username"].ToString(),
                    Email = reader["Email"].ToString(),
                    Region = reader["Region"].ToString(),
                    IsSubscribed = reader["IsSubscribed"] is bool b ? b : false,
                    JoinDate = reader["JoinDate"] is DateTime dt ? dt : DateTime.MinValue
                });
            }
            return list;
        }

        [Benchmark]
        public List<Player> Where_Dapper() =>
            connection.Query<Player>("SELECT * FROM Players WHERE Region = @region", new { region = "EUW" }).ToList();

        [Benchmark]
        public List<Player> Where_EF() =>
            context.Players.Where(p => p.Region == "EUW").ToList();



        [Benchmark]
        public Player FirstOrDefault_ADO()
        {
            using var cmd = new SqlCommand("SELECT TOP 1 * FROM Players WHERE Username = 'Armando_Kreiger'", connection);
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) 
                return new Player 
                {
                    Id = (int)reader["Id"],
                    Username = reader["Username"].ToString(),
                    Email = reader["Email"].ToString(),
                    Region = reader["Region"].ToString(),
                    IsSubscribed = reader["IsSubscribed"] is bool b ? b : false,
                    JoinDate = reader["JoinDate"] is DateTime dt ? dt : DateTime.MinValue
                };
            return null;
        }

        [Benchmark]
        public Player FirstOrDefault_Dapper() =>
            connection.QueryFirstOrDefault<Player>("SELECT * FROM Players WHERE Username = @name", new { name = "Armando_Kreiger" });

        [Benchmark]
        public Player FirstOrDefault_EF() =>
            context.Players.FirstOrDefault(p => p.Username == "Armando_Kreiger");

    }
}
