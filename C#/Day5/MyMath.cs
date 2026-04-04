using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class MyMath
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Cannot divide by zero - will return first number");
                return a;
            }
        }
    }
}
