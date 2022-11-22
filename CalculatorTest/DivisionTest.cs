using Labb3_XUnitAndAcceptance;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class DivisionTest
    {
        [Fact]
        public void Division10By2Return5()
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.division(10, 2);

            // Act
            var expected = 5;
            var actual = calc.result;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(53, 12)]
        [InlineData(-5, -5)]
        [InlineData(20, 100)]
        [InlineData(123, 321)]
        public void DivisionTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };
            calc.division(num1, num2);

            //Act
            var expected = num1 / num2;
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
