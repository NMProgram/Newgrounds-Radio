namespace Tests.Unit;

using NGRadio.MenuSystem;

public class MenuPosTests
{
    [Theory]
    [InlineData(10, 11)]
    [InlineData(1, 3)]
    [InlineData(398, 9023)]
    public void MoveUp_Positive_ReturnsDecrementedValue(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveUp();
        // Assert
        Assert.Equal(index - 1, newPos.Value);
    }

    [Theory]
    [InlineData(0, 11)]
    [InlineData(-344, 3)]
    [InlineData(-843923980, 9023)]
    public void MoveUp_Negative_ReturnsMaxMinus1(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveUp();
        // Assert
        Assert.Equal(max - 1, newPos.Value);
    }

    [Theory]
    [InlineData(9, 11)]
    [InlineData(0, 3)]
    [InlineData(432, 9023)]
    public void MoveDown_BelowMax_ReturnsIncrementedValue(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveDown();
        // Assert
        Assert.Equal(index + 1, newPos.Value);
    }

    [Theory]
    [InlineData(10, 11)]
    [InlineData(88, 3)]
    public void MoveDown_AboveMax_ReturnsZero(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveDown();
        // Assert
        Assert.Equal(0, newPos.Value);
    }

    [Theory]
    [InlineData(10, 9, 20)]
    [InlineData(10, 0, 13)]
    [InlineData(440, 432, 9023)]
    public void MoveRight_BelowMax_ReturnsIndexPlusPageCountFloored(int exp, int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveRight();
        // Assert
        Assert.Equal(exp, newPos.Value);
    }

    [Theory]
    [InlineData(10, 20)]
    [InlineData(20, 13)]
    [InlineData(43298, 9023)]
    public void MoveRight_AboveMax_ReturnsZero(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveRight();
        // Assert
        Assert.Equal(0, newPos.Value);
    }

    [Theory]
    [InlineData(0, 10, 11)]
    [InlineData(10, 25, 33)]
    [InlineData(380, 398, 9023)]
    public void MoveLeft_Positive_ReturnsIndexMinusPageCountFloored(int exp, int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveLeft();
        // Assert
        Assert.Equal(exp, newPos.Value);
    }

    [Theory]
    [InlineData(9, 12)]
    [InlineData(-1, 3)]
    public void MoveLeft_Negative_ReturnsMaxMinus1(int index, int max)
    {
        // Arrange
        MenuPos pos = new(index, max);
        // Act
        MenuPos newPos = pos.MoveLeft();
        // Assert
        Assert.Equal(max - 1, newPos.Value);
    }
}