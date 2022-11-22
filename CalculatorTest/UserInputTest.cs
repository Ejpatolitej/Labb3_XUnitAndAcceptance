using Labb3_XUnitAndAcceptance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTest
{
    public class UserInputTest
    {

        [Fact]
        public void UserInputTestShouldBe5()
        {
            // Arrange
            Calculator calc = new Calculator { calculations = new List<string>() };

            // Act
            calc.firstInput();
            var expected = 1;

            var actual = calc.num1;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
