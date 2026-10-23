namespace Tests;

using NGRadio;

public class RangeTests
{
    [Fact]
    public void Create_MinIsGreaterThanMax_ThrowsArgumentOutOfRangeException()
    {
        // Given
        int min = 10;
        int max = min - 1;
        // When
        Range Create() => new Range(min, max);
        // Then
        Assert.Throws<ArgumentOutOfRangeException>(Create);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    public void HasValue_WithinRange_ReturnsTrue(int value)
    {
        // Given
        Range r = new Range(1, 10);
        // When
        bool inRange = r.HasValue(value);
        // Then
        Assert.True(inRange, "Value in range should return true.");
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(3)]
    public void HasValue_OutsideRange_ReturnsTrue(int value)
    {
        // Given
        Range r = new Range(1, 2);
        // When
        bool inRange = r.HasValue(value);
        // Then
        Assert.False(inRange, "Value outside range should return false.");
    }
}