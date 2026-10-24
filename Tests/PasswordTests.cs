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
        PasswordValidator validator = new PasswordValidator();
        bool exp = validator.Validate(pass);
        // When
        bool valid = pwd.Validate(validator);
        // Then
        Assert.Equal(exp, valid);
    }

    [Theory]
    [InlineData("Lorem ipsum")]
    public void Hash_Password_UsesBase64SHA256Hasher(string pass)
    {
        // Given
        Password pwd = new Password(pass);
        Base64SHA256Hasher hasher = new Base64SHA256Hasher();
        string expHash = hasher.Hash(pass);
        // When
        string hash = pwd.Hash(hasher);
        // Then
        Assert.Equal(expHash, hash);
    }
}