using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(-5, -4, -6, -15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange

            Calculator instance = new Calculator();

            //Act
            int result = instance.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(-4, 5, -9)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
            int result = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(-2, -4, 8)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator mult = new Calculator();
            //Act
            int result = mult.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(-6, -2, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            int result = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
