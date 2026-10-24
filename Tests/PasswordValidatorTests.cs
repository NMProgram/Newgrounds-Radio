namespace Tests;

using NGRadio;

public class PasswordValidatorTests
{
    const string Has120Chars = "JDSKJDKSDJKLDSJKLDKJLSDJKSKaLDSJDKSJDLKSJKLSDJKLDJKSS6JKLDSJKDLSJKLDKJSLDJKSKJDLSJKDSKJLDSJKLDSKJLDSJKLDSKJLDJJSKLDSDSA@";

    [Theory]
    [InlineData("H@s8Chrs")]
    [InlineData("SoTh1sOneWillH@ve64CharsWhichIsQuiteALotIfYouThinkAboutItButOkay")]
    [InlineData(Has120Chars)]
    public void Validate_Success_ReturnsTrue(string pass)
    {
        // Given
        PasswordValidator validator = new PasswordValidator();
        // When
        bool valid = validator.Validate(pass);
        // Then
        Assert.True(valid, $"Password {pass} should be valid.");
    }

    [Theory]
    [InlineData("               ")] // only whitespace
    [InlineData("nocapitalsh3re!")]
    [InlineData("NOLOWERCASEH3RE!")]
    [InlineData("ThereIsNoDigitHere!")]
    [InlineData("NoSymbolHere2")]
    [InlineData("Th1sHas┤Som3NonAscii┤!")]
    public void Validate_InvalidChars_ReturnsFalse(string pass)
    {
        // Given
        PasswordValidator validator = new PasswordValidator();
        // When
        bool valid = validator.Validate(pass);
        // Then
        Assert.False(valid, "Password with invalid chars should not be valid.");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("a")]
    [InlineData("1234567")]
    [InlineData($"{Has120Chars}a")]
    public void Validate_OutOfRange_ReturnsFalse(string? pass)
    {
        // Given
        PasswordValidator validator = new PasswordValidator();
        // When
        bool valid = validator.Validate(pass);
        // Then
        Assert.False(valid, "Password not between 8-120 chars should not be valid.");
    }
}
