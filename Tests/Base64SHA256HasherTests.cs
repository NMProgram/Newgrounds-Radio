namespace Tests;

using NGRadio;

public class Base64SHA256HasherTests
{
    [Theory]
    [InlineData("Hello!")]
    public void Hash_Equality_ReturnsEqualHash(string value)
    {
        // Given
        Base64SHA256Hasher hasher = new Base64SHA256Hasher();
        // When
        string hash1 = hasher.Hash(value);
        string hash2 = hasher.Hash(value);
        // Then
        Assert.NotEqual(value, hash1);
        Assert.Equal(hash1, hash2);
    }

    [Theory]
    [InlineData("Hello!", "hElLo!")]
    public void Hash_Inequality_ReturnsNewHash(string left, string right)
    {
        // Given
        Base64SHA256Hasher hasher = new Base64SHA256Hasher();
        // When
        string hash1 = hasher.Hash(left);
        string hash2 = hasher.Hash(right);
        // Then
        Assert.NotEqual(hash1, hash2);
    }
}
