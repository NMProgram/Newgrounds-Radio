namespace Tests;

using NGRadio;

public class PasswordTests
{
    const string Has120Chars = "JDSKJDKSDJKLDSJKLDKJLSDJKSKaLDSJDKSJDLKSJKLSDJKLDJKSS6JKLDSJKDLSJKLDKJSLDJKSKJDLSJKDSKJLDSJKLDSKJLDSJKLDSKJLDJJSKLDSDSA@";

    [Theory]
    [InlineData("H@s8Chrs")]
    [InlineData("SoTh1sOneWillH@ve64CharsWhichIsQuiteALotIfYouThinkAboutItButOkay")]
    [InlineData(Has120Chars)]
    public void Validate_Success_ReturnsTrue(string pass)
    {
        // Given
        Password pwd = new Password(pass);
        // When
        bool valid = pwd.Validate();
        // Then
        Assert.True(valid, $"Password {pass} should be valid.");
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
        Password pwd = new Password(pass);
        // When
        bool valid = pwd.Validate();
        // Then
        Assert.False(valid, "Password not between 8-120 chars should not be valid.");
    }

    [Theory]
    [InlineData("nocapitalsh3re!")]
    [InlineData("NOLOWERCASEH3RE!")]
    [InlineData("ThereIsNoDigitHere!")]
    [InlineData("NoSymbolHere2")]
    [InlineData("Th1sHas┤Som3NonAscii┤!")]
    public void Validate_InvalidChars_ReturnsFalse(string pass)
    {
        // Given
        Password pwd = new Password(pass);
        // When
        bool valid = pwd.Validate();
        // Then
        Assert.False(valid, "Password with invalid chars should not be valid.");
    }

    [Fact]
    public void Hash_Equality_ReturnsEqualHash()
    {
        // Given
        string pass = "Hello!";
        Password pwd = new Password(pass);
        Password pwd2 = new Password(pass);
        // When
        string hash1 = pwd.Hash();
        string hash2 = pwd2.Hash();
        // Then
        Assert.NotEqual(pass, hash1);
        Assert.Equal(hash1, hash2);
    }

    [Fact]
    public void Hash_Inequality_ReturnsNewHash()
    {
        // Given
        Password pwd1 = new Password("Hello!");
        Password pwd2 = new Password("hElLo!");
        // When
        string hash1 = pwd1.Hash();
        string hash2 = pwd2.Hash();
        // Then
        Assert.NotEqual(hash1, hash2);
    }
}