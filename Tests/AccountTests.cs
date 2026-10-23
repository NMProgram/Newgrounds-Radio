namespace Tests;

using NGRadio;

public class AccountTests
{
    [Theory]
    [InlineData("Tri")] // 3
    [InlineData("AnythingThere")] // 12
    [InlineData("ReachTheThirtyCharacterMarkMan")] // 30
    [InlineData("A-IsFine")] // has -
    [InlineData("SoIsAn_Here")] // has _
    [InlineData("Both_AreAllowed-Too")] // has _ and -
    [InlineData("Dig1tsAreFine2")] // has digit
    public void IsValidName_Success_ReturnsTrue(string name)
    {
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.True(valid, $"Name {name} should be valid.");
    }

    [Theory]
    [InlineData("                  ")] // only whitespace
    [InlineData("£IsNotASCII")] // has non-ASCII
    [InlineData("ThisHas@Symbol")] // has non-letter/digit
    [InlineData("ThisEndsInSymbol!")] // ends on non-letter/digit
    [InlineData("ThisNameCannotEndIn_")] // ends in _
    [InlineData("NeitherCanItEndIn-")] // ends in -
    public void IsValidName_NonAsciiLetterOrDigit_ReturnsFalse(string name)
    {
        // Given
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Name with non-ASCII chars or ending in -/_ should not be valid.");
    }

    [Theory]
    [InlineData(null)] // null
    [InlineData("")] // empty
    [InlineData("a")] // 1 char
    [InlineData("AB")] // 2 chars
    [InlineData("ThisIs31CharsLongBecauseWhyStop")] // 31 chars
    public void IsValidName_OutOfRange_ReturnsFalse(string? name)
    {
        // Given
        // When
        bool valid = Account.IsValidName(name);
        // Then
        Assert.False(valid, "Name not in range 3-30 chars should be invalid.");
    }

    const string Has120Chars = "JDSKJDKSDJKLDSJKLDKJLSDJKSKJLDSJDKSJDLKSJKLSDJKLDJKSSJKLDSJKDLSJKLDKJSLDJKSKJDLSJKDSKJLDSJKLDSKJLDSJKLDSKJLDJJSKLDSDSABC";

    [Theory]
    [InlineData("SomethingValid")]
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
        Assert.False(valid, $"Password not between 8-120 chars should not be valid.");
    }
}