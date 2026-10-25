namespace Tests;

using NGRadio;

public class AccountTests
{
    [Fact]
    public void Create_Name_ReturnsAccount()
    {
        // Given
        string name = "Name";
        // When
        Account acc = new Account(name);
        // Then
        Assert.Equal(name, acc.Name);
    }

    const byte equal = 0;
    const sbyte lessThan = -1;
    const byte greaterThan = 1;

    [Theory]
    [InlineData(equal, "Name1", "Name1")]
    [InlineData(lessThan, "Name1", "Name2")]
    [InlineData(greaterThan, "Name2", "Name1")]
    public void CompareTo_ReturnsSignedByte(sbyte exp, string left, string right)
    {
        // Given
        Account acc1 = new Account(left);
        Account acc2 = new Account(right);
        // When
        int compared = acc1.CompareTo(acc2);
        // Then
        Assert.Equal(exp, compared);
    }
}