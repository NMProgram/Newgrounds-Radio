namespace Tests;

using NGRadio;

public class UsernameTests
{
    [Fact]
    public void Validate_UsesUsernameValidator()
    {
        // Given
        string name = "Anything";
        Username username = new Username(name);
        bool exp = new UsernameValidator().Validate(name);
        // When
        bool valid = username.Validate();
        // Then
        Assert.Equal(exp, valid);
    }
}