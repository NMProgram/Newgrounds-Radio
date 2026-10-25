namespace Tests;

using NGRadio;

public class AccountTests
{
    [Fact]
    public void Create_ReturnsAccount()
    {
        // Given
        string name = "Name";
        // When
        Account acc = new Account(name);
        // Then
        Assert.Equal(name, acc.Name);
    }
}