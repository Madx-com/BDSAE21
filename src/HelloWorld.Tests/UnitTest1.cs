using System;
using Xunit;
using HelloWorld;

namespace HelloWorld.Tests
{
    public class HelloWorldTest
    {
        [Theory]
        [InlineData(1612)]
        [InlineData(1760)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsYearDivByFour(int candidate)
        {
            // Arrange
            bool isleap = false;
            var pro = new Program();

            // Act
            isleap = Program.IsLeapYear(candidate);

            // Assert
            Assert.True(isleap);
        }
    }
}
