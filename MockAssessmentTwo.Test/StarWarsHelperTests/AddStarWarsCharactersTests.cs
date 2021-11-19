using System;
using System.Collections.Generic;
using System.Text;
using MockAssessmentTwo;
using Xunit;

namespace MockAssessmentTwo.Tests.StarWarsHelperTests
{

    public class AddStarWarsCharactersTests
    {
        [Fact]
        public void YodaIsNotInTheArray_ReturnsNegativeOne()
        {
            // Arrange
            StarWarsHelper subject = new StarWarsHelper();
            string[] people = new string[] { "Luke", "Leia", "Han" };

            // Act
            int returnValue = subject.AddStarWarsCharacters(people);

            // Assert
            Assert.Equal(-1, returnValue);
        }

        [Theory]
        [InlineData(new string[]{ "Luke", "Leia", "Yoda", "Han" },2)]
        [InlineData(new string[] { "Leia", "Yoda" }, 1)]
        [InlineData(new string[] 
        { "Vader","Luke", "Leia", "Yoda", "Han" }, 3)]    
        public void YodaIsInTheArray_ReturnsIndexValue
            (string[] people,int expectedValue)
        {
            //Arrange
            StarWarsHelper subject = new StarWarsHelper();
       
            // Act
            int returnValue = subject.AddStarWarsCharacters(people);

            // Assert
            Assert.Equal(expectedValue, returnValue);
        }

        [Fact]
        public void YodaIsInTheArrayMoreThanOnce_ReturnsTheFirstIndex()
        {
            // Arrange
            StarWarsHelper subject = new StarWarsHelper();
            string[] people = new string[] 
            { "Yoda","Luke", "Leia","Yoda", "Han" };

            // Act
            int returnValue = subject.AddStarWarsCharacters(people);

            // Assert
            Assert.Equal(0, returnValue);
        }

        [Fact]
        public void ArrayElementIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            StarWarsHelper subject = new StarWarsHelper();
            string[] people = new string[1];

            // Act
            Action action = () => subject.AddStarWarsCharacters(people);

            // Assert
            Assert.Throws<ArgumentNullException>(action);


        }
    }
}
