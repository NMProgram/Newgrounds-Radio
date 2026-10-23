namespace Tests;

using NGRadio;

public class RangeTests
{
    [Fact]
    public void HasValue_WithinRange_ReturnsTrue()
    {
        // Given
        Range r = new Range(1, 10);
        // When
        bool inRange = r.HasValue(5);
        // Then
        Assert.True(inRange, "Value in range should return true.");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(4)]
    public void HasValue_OutsideRange_ReturnsTrue(int value)
    {
        // Given
        Range r = new Range(1, 3);
        // When
        bool inRange = r.HasValue(value);
        // Then
        Assert.False(inRange, "Value outside range should return false.");
    }
}