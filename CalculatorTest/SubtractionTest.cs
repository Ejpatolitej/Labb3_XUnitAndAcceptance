using Labb3_XUnitAndAcceptance;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class SubtractionTest
    {
        [Fact]
        public void Subtraction100Minus13Return87()
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.subtraction(100, 13);

            // Act
            var expected = 87;
            var actual = calc.result;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(101, 10)]
        [InlineData(15, -5)]
        [InlineData(-100, -1001)]
        [InlineData(7, 789123)]
        public void SubtractionTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.subtraction(num1, num2);

            //Act
            var expected = num1 - num2;
            var actual = calc.result;
            bool test;
            if (expected == actual)
            {
                test = true;
            }
            else
            {
                test = false;
            }

            //Assert
            Assert.True(test);
        }

    }
}
