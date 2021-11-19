using System;
using System.Collections.Generic;
using System.Text;
using AhbcOctoberWeekSix;
using Xunit;

namespace AhbcOctoberWeekSix.Tests
{
    public class ArithmeticTests
    {
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(-2, -3, -5)]
        [InlineData(2000, 3000, 5000)]
        [InlineData(-2, 3, 1)]
        [InlineData(4, 0, 4)]
        public void TwoNumbersAreGiven_NumbersWillBeAddedTogether
            (int numberOne, int numberTwo, int result )
        {          
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            int testTotal = subject.Sum(numberOne, numberTwo);
            
            // Assert
            Assert.Equal(result,testTotal);
        } 

       [Fact]
       public void TheSameNumberIsGivenTwice_AnExceptionIsThrown()
        {
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            Action test = () => subject.Sum(2, 2);

            // Assert
            Assert.Throws<InvalidOperationException>(test);
        }

    }
}
