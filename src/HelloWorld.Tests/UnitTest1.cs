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

            // Act
            isleap = Program.IsLeapYear(candidate);

            // Assert
            Assert.True(isleap);
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsDivBy4BAnd100NotLeapYear(int candidate)
        {
            // Arrange
            bool isnotleap = true;

            // Act
            isnotleap = Program.IsLeapYear(candidate);

            // Assert
            Assert.False(isnotleap);
        }

        [Theory]
        [InlineData(1582)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsNotLeapYear(int candidate)
        {
            // Arrange
            bool isnotleap = true;

            // Act
            isnotleap = Program.IsLeapYear(candidate);

            // Assert
            Assert.False(isnotleap);
        }
    }
}
