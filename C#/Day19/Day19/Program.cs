using BenchmarkDotNet.Running;
using System;
using System.Configuration;
namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Benchmark");
            var _ = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
