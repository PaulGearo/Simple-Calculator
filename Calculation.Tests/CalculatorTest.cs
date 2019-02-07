using System;
using Xunit;
using Calculator_Project;

namespace Calculation.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]

        public void Add(int[] numbers, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]

        public void Subtract(int a, int b, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]

        public void Multiply(int a, int b, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]

        public void Divide(double a, int b, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double actual = calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 2, 2, 4)]

        public void Exponents(double a, long b, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double actual = calculator.Exponents(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1*2*3)]

        public void Factorial(int number, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Factorial(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
