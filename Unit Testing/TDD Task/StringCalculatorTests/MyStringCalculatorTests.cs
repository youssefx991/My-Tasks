using MyConsoleApp;

namespace StringCalculatorTests
{
    public class MyStringCalculatorTests
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var result = calculator.Add("");
            // Assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void Add_OneNumber_ReturnsThatNumber()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var result = calculator.Add("5");
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsTheirSum()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var result = calculator.Add("3,4");
            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Add_UnknownNumberOfNumbers_ReturnsTheirSum()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var result = calculator.Add("1,2,3,4,5");
            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_NumbersWithNewLines_ReturnsTheirSum()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var result = calculator.Add("1\n2,3");
            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ThrowsException()
        {
            // Arrange
            var calculator = new StringCalculator();
            // Act
            var exception = Assert.Throws<Exception>(() => calculator.Add("1,-2,3,-4"));
            // Assert
            Assert.Equal("negatives not allowed: -2,-4", exception.Message);
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