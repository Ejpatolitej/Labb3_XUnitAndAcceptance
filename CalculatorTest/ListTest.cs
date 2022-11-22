using Labb3_XUnitAndAcceptance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTest
{
    public class ListTest
    {
        [Fact]
        public void ListShouldNotBeNull()
        {
            // Arrange
            Calculator calc = new Calculator();

            //Act
            calc.calculations = new List<string>();
            calc.addition(10, 10);

            //Assert
            Assert.NotEmpty(calc.calculations);
        }

    }
}
