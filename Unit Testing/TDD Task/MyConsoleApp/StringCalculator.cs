using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    public class StringCalculator
    {
        public StringCalculator()
        {
            
        }

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            var delimiters = new char[] { ',', '\n' };
            var numbersInt = numbers.Split(delimiters).Select(int.Parse).ToList();
            int sum = numbersInt.Sum();
            var negativesInt = numbersInt.Where(n => n < 0).ToList();
            
            if (negativesInt.Any()) {
                throw new Exception($"negatives not allowed: {string.Join(",", negativesInt)}");
            }

            return sum;
        }
    }
}


/*
 * Create a StringCalculator with the following requirements:

1) method Add(string numbers) that returns an integer.
	Start with the simplest test case of an empty string, then 1 number, then 2.
	An empty string should return a sum of 0.
	String of numbers can include 0, 1, or 2 integers (e.g. "", "1", "1,2").
	Add returns the sum of the integers provided in the string numbers.
	Remember to refactor after each test.

2) Allow the Add method to handle an unknown number of numbers (in the string).

3) Allow the Add method to handle new lines between numbers (instead of commas).
	The following input is ok: “1\n2,3” (will equal 6)

4) Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
	If there are multiple negatives, show all of them in the exception message.
 */