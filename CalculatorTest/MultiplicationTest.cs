using Labb3_XUnitAndAcceptance;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class MultiplicationTest
    {
        [Fact]
        public void Multiplication10Times10Return100()
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.multiplication(10, 10);

            // Act
            var expected = 100;
            var actual = calc.result;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(21, 12)]
        [InlineData(-10, -10)]
        [InlineData(1, 100)]
        [InlineData(333, 333)]
        public void MultiplicationTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.multiplication(num1, num2);

            //Act
            var expected = num1 * num2;
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
