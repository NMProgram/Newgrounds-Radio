namespace NGRadio.Models.DTOs;

/// <summary>
/// Represents a response containing a user's account.
/// </summary>
public class AccountResponse : IComparable<AccountResponse>
{
    /// <summary>
    /// Creates a new instance of the <see cref="AccountResponse"/> class.
    /// </summary>
    /// <param name="name"><inheritdoc cref="Name" path="/value"/></param>
    public AccountResponse(string name)
    {
        Name = name;
    }

    /// <inheritdoc cref="Account.Name"/>
    public string Name { get; }

    /// <inheritdoc/>
    public int CompareTo(AccountResponse? other) => Name.CompareTo(other?.Name);
}
