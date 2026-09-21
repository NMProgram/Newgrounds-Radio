namespace Tests.Unit;

using NGRadio.Logic;

public class IntUtilsTests
{
    [Theory]
    [InlineData(10, 15, 10)]
    [InlineData(10, 10, 10)]
    [InlineData(98, 99, 7)]
    public void Floor_ReturnsIntegerWithoutRemainder(int exp, int value, int divisor)
    {
        // Arrange
        // Act
        int result = IntUtils.Floor(value, divisor);
        // Assert
        Assert.Equal(exp, result);
    }

    [Theory]
    [InlineData(10, 10, 15)]
    [InlineData(0, 10, 8)]
    [InlineData(0, 0, 2)]
    public void WrapToZero_SameConversion_ReturnsWrappedValue(int exp, int value, int max)
    {
        // Arrange
        // Act
        int result = IntUtils.WrapToZero(value, max, v => v);
        // Assert
        Assert.Equal(exp, result);
    }

    [Theory]
    [InlineData(11, 10, 15)]
    [InlineData(0, 10, 8)]
    [InlineData(1, 0, 2)]
    public void WrapToZero_WithIncrement_ReturnsConvertedValue(int exp, int value, int max)
    {
        // Arrange
        // Act
        int result = IntUtils.WrapToZero(value, max, v => v + 1);
        // Assert
        Assert.Equal(exp, result);
    }

    [Theory]
    [InlineData(10, 10, 15)]
    [InlineData(7, -5, 8)]
    [InlineData(0, 0, 2)]
    public void WrapToMax_SameConversion_ReturnsWrappedValue(int exp, int value, int max)
    {
        // Arrange
        // Act
        int result = IntUtils.WrapToMax(value, max, v => v);
        // Assert
        Assert.Equal(exp, result);
    }

    [Theory]
    [InlineData(11, 10, 15)]
    [InlineData(7, -5, 8)]
    [InlineData(1, 0, 2)]
    public void WrapToMax_WithIncrement_ReturnsConvertedValue(int exp, int value, int max)
    {
        // Arrange
        // Act
        int result = IntUtils.WrapToMax(value, max, v => v + 1);
        // Assert
        Assert.Equal(exp, result);
    }
}