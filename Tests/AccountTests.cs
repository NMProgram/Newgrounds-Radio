namespace Tests;

using NGRadio;
using Tests.Data;

public class AccountTests
{
    [Fact]
    public void Create_WithName_ReturnsAccount()
    {
        // Given
        string name = "Name";
        // When
        Account acc = new Account(name);
        // Then
        Assert.Equal(name, acc.Name);
    }

    [Fact]
    public void Create_WithNameAndPassword_ReturnsAccount()
    {
        // Given
        string name = "Name";
        string pass = "Password";
        // When
        Account acc = new Account(name, pass);
        // Then
        Assert.Equal(name, acc.Name);
        Assert.Equal(pass, acc.Password);
    }

    [Theory]
    [InlineData(Comparison.Equal, "Name1", "Name1")]
    [InlineData(Comparison.LessThan, "Name1", "Name2")]
    [InlineData(Comparison.GreaterThan, "Name1", null)]
    [InlineData(Comparison.GreaterThan, "Name2", "Name1")]
    public void CompareTo_ReturnsSignedByte(Comparison exp, string left, string? right)
    {
        // Given
        Account acc1 = new Account(left);
        Account acc2 = new Account(right!);
        // When
        int compared = acc1.CompareTo(acc2);
        // Then
        Assert.Equal(Convert.ToInt32(exp), compared);
    }
}