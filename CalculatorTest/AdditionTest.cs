using Labb3_XUnitAndAcceptance;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class AdditionTest
    {
        [Fact]
        public void addition20plus10return30()
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.addition(20, 10);

            // Act
            var expected = 30;
            var actual = calc.result;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(12, 21)]
        [InlineData(-14, -5)]
        [InlineData(20, -100)]
        [InlineData(700, 123489418156)]
        public void AdditionTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.addition(num1, num2);

            //Act
            var expected = num1 + num2;
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
