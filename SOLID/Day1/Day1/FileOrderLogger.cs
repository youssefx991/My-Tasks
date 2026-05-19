using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class FileOrderLogger : IOrderLogger
    { 
        public void Log(string msg) => Console.WriteLine($"[LOG] {msg}"); 
    }
}
