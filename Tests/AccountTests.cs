namespace Tests;

using NGRadio;

public class AccountTests
{
    [Theory]
    [InlineData("Anything")]
    [InlineData("Tri")]
    [InlineData("ReachTheThirtyCharacterMarkMan")]
    [InlineData("A-IsFine")]
    [InlineData("SoIsAn_Here")]
    public void IsValidName_Success_ReturnsTrue(string name)
    {
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.True(valid, $"Name {name} should be valid.");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void IsValidName_NullOrEmptyOrWhitespace_ReturnsFalse(string? name)
    {
        // Given empty or whitespace
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Empty, whitespace-only or non-ASCII names should not be valid.");
    }

    [Theory]
    [InlineData("£IsNotASCII")]
    public void IsAllAscii_NonAscii_ReturnsFalse(string name)
    {
        // Given £
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Name with non-ASCII chars should not be valid.");
    }

    [Theory]
    [InlineData("AB")]
    [InlineData("A")]
    [InlineData("ThisIs31CharsLongBecauseWhyStop")]
    public void IsValidName_OutOfRange_ReturnsFalse(string name)
    {
        // Given
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Name not in range 3-30 chars should be invalid.");
    }

    [Theory]
    [InlineData("ThisHas@Symbol")]
    public void IsValidName_HasSymbols_ReturnsFalse(string name)
    {
        // Given
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Name with symbols should not be valid.");
    }
}