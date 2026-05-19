using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class ConsoleOrderLogger : IOrderLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
