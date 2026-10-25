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
    public void Create_WithNameAndPassword_ReturnsAccountRequest()
    {
        // Given
        string name = "Name";
        string pass = "Password";
        // When
        AccountRequest acc = new AccountRequest(name, pass);
        // Then
        Assert.Equal(pass, acc.Password);
        Assert.IsType<Account>(acc, exactMatch: false);
    }

    [Fact]
    public void Create_WithNameAndPassword_ReturnsAccountEntity()
    {
        // Given
        string name = "Name";
        string pass = "Password";
        Guid guid = Guid.NewGuid();
        // When
        AccountEntity acc = new AccountEntity(guid, name, pass);
        // Then
        Assert.Equal(guid, acc.ID);
        Assert.IsType<AccountRequest>(acc, exactMatch: false);
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