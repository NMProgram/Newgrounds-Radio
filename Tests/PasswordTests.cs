namespace Tests;

using NGRadio;

public class PasswordTests
{
    [Theory]
    [InlineData("nocapitalsh3re!")]
    [InlineData(null)]
    [InlineData("1234567")]
    [InlineData("H@s8Chrs")]
    public void Validate_Password_UsesPasswordValidator(string? pass)
    {
        // Given
        Password pwd = new Password(pass);
        bool exp = PasswordValidator.Default.Validate(pass);
        // When
        bool valid = pwd.Validate();
        // Then
        Assert.Equal(exp, valid);
    }

    [Theory]
    [InlineData("Lorem ipsum")]
    public void Value_HashesPassword_UsesBase64SHA256Hasher(string pass)
    {
        // Given
        Password pwd = new Password(pass);
        string expHash = Base64SHA256Hasher.Default.Hash(pass);
        // When
        string hash = pwd.Value;
        // Then
        Assert.Equal(expHash, hash);
    }
}