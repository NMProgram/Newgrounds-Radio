namespace Tests;

using NGRadio;

public class AccountTests
{
    const string Has120Chars = "JDSKJDKSDJKLDSJKLDKJLSDJKSKaLDSJDKSJDLKSJKLSDJKLDJKSS6JKLDSJKDLSJKLDKJSLDJKSKJDLSJKDSKJLDSJKLDSKJLDSJKLDSKJLDJJSKLDSDSA@";

    [Theory]
    [InlineData("SomethingValid!1")]
    [InlineData("1HasThe_Character")]
    [InlineData("3HasThe^Character")]
    [InlineData(Has120Chars)]
    public void IsValidPassword_Success_ReturnsTrue(string pass)
    {
        // Given
        // When
        bool valid = Account.IsValidPassword(pass);
        // Then
        Assert.True(valid, $"Password {pass} should be valid.");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    [InlineData("1234567")]
    [InlineData("1")]
    [InlineData($"{Has120Chars}a")]
    public void IsValidPassword_OutOfRange_ReturnsFalse(string? pass)
    {
        // Given
        // When
        bool valid = Account.IsValidPassword(pass);
        // Then
        Assert.False(valid, "Password not between 8-120 chars should not be valid.");
    }

    [Theory]
    [InlineData("NoSymbolHere")]
    public void IsValidPassword_MissingSymbol_ReturnsFalse(string pass)
    {
        // Given
        // When
        bool valid = Account.IsValidPassword(pass);
        // Then
        Assert.False(valid, "Password with no symbol should not be valid.");
    }

    [Theory]
    [InlineData("nocapitalshere!")]
    [InlineData("NOLOWERCASEHERE!")]
    [InlineData("ThereIsNoDigitHere!")]
    public void IsValidPassword_MissingChar_ReturnsFalse(string pass)
    {
        // Given
        // When
        bool valid = Account.IsValidPassword(pass);
        // Then
        Assert.False(valid, "Password with missing lowercase/uppercase/digits should not be valid.");
    }

    [Theory]
    [InlineData("Th1sHasSomeNonAscii┤!")]
    public void IsValidPassword_NonASCII_ReturnsFalse(string pass)
    {
        // Given
        // When
        bool valid = Account.IsValidPassword(pass);
        // Then
        Assert.False(valid, "Password with non-ASCII chars should not be valid.");
    }
}
