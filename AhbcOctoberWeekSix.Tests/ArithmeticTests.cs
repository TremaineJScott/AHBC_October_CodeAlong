using System;
using System.Collections.Generic;
using System.Text;
using AhbcOctoberWeekSix;
using Xunit;

namespace AhbcOctoberWeekSix.Tests
{
    public class ArithmeticTests
    {
        [Fact]
        public void TwoNumbersAreGiven_NumbersWillBeAddedTogether()
        {          
            // Arrange
            ArithmeticHelper subject = new ArithmeticHelper();

            // Act
            int testTotal = subject.Sum(2, 3);

            // Assert
            Assert.Equal(5,testTotal);
        }
    }
}
