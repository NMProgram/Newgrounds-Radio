namespace Tests.Unit;

using NGRadio.MenuSystem;

public class MenuCursorTests
{
    [Theory]
    [InlineData(10, 11)]
    [InlineData(1, 3)]
    [InlineData(398, 9023)]
    public void MoveUp_Positive_ReturnsDecrementedValue(int index, int max)
    {
        // Arrange
        MenuCursor curs = new MenuCursor(index, max);
        // Act
        ICursor newCursor = curs.Up;
        // Assert
        Assert.Equal(index - 1, newCursor.Index);
    }

    [Theory]
    [InlineData(0, 11)]
    [InlineData(-344, 3)]
    [InlineData(-843923980, 9023)]
    public void MoveUp_Negative_ReturnsMaxMinus1(int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Up;
        // Assert
        Assert.Equal(max - 1, newCursor.Index);
    }

    [Theory]
    [InlineData(9, 11)]
    [InlineData(0, 3)]
    [InlineData(432, 9023)]
    public void MoveDown_BelowMax_ReturnsIncrementedValue(int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Down;
        // Assert
        Assert.Equal(index + 1, newCursor.Index);
    }

    [Theory]
    [InlineData(10, 11)]
    [InlineData(88, 3)]
    public void MoveDown_AboveMax_ReturnsZero(int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Down;
        // Assert
        Assert.Equal(0, newCursor.Index);
    }

    [Theory]
    [InlineData(10, 9, 20)]
    [InlineData(10, 0, 13)]
    [InlineData(440, 432, 9023)]
    public void MoveRight_BelowMax_ReturnsIndexPlusPageCountFloored(int exp, int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Right;
        // Assert
        Assert.Equal(exp, newCursor.Index);
    }

    [Theory]
    [InlineData(10, 20)]
    [InlineData(20, 13)]
    [InlineData(43298, 9023)]
    public void MoveRight_AboveMax_ReturnsZero(int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Right;
        // Assert
        Assert.Equal(0, newCursor.Index);
    }

    [Theory]
    [InlineData(0, 10, 11)]
    [InlineData(10, 25, 33)]
    [InlineData(380, 398, 9023)]
    public void MoveLeft_Positive_ReturnsIndexMinusPageCountFloored(int exp, int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Left;
        // Assert
        Assert.Equal(exp, newCursor.Index);
    }

    [Theory]
    [InlineData(9, 12)]
    [InlineData(-1, 3)]
    public void MoveLeft_Negative_ReturnsMaxMinus1(int index, int max)
    {
        // Arrange
        MenuCursor cursor = new(index, max);
        // Act
        ICursor newCursor = cursor.Left;
        // Assert
        Assert.Equal(max - 1, newCursor.Index);
    }
}