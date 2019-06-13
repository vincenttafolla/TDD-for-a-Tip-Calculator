using System;
using Xunit;
using TipCalculator;

namespace TipCalcTests
{
    public class TipperTests
    {
        [Theory]
        [InlineData(100.00, 15.00)]
        [InlineData(50.00, 7.50)]
        [InlineData(25.00, 3.75)]
        [InlineData(6.66, 1)]
        [InlineData(5, 1)]
        [InlineData(0, 1)]
        [InlineData(-5, 1)]
        public void ShouldCalculateTipAmount(decimal checkAmount, decimal expected)
        {
            // Arrange
            Tipper tipper = new Tipper();

            // Act
            decimal actual = tipper.CalculateTip(checkAmount);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
