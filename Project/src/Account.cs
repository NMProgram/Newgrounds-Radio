namespace NGRadio;

/// <summary>
/// Represents a user's account.
/// </summary>
public class Account : IComparable<Account>
{
    /// <summary>
    /// Creates a new instance of the <see cref="Account"/> class.
    /// </summary>
    /// <param name="name"><inheritdoc cref="Name" path="/value"/></param>
    public Account(string name)
    {
        Name = name;
    }

    /// <summary>Gets the name of the account.</summary>
    /// <value>The name of the account.</value>
    public string Name { get; }

    /// <inheritdoc/>
    public int CompareTo(Account? other) => Name.CompareTo(other?.Name);
}
