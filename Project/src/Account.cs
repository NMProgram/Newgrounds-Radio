namespace NGRadio;

/// <summary>
/// Represents a user's account.
/// </summary>
public class Account : IComparable<Account>
{
    /// <inheritdoc cref="Account(string, string)"/>
    public Account(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Account"/> class.
    /// </summary>
    /// <param name="name"><inheritdoc cref="Name" path="/value"/></param>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public Account(string name, string pass)
    : this(name)
    {
        Password = pass;
    }

    /// <summary>Gets the name of the account.</summary>
    /// <value>The name of the account.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the password of the account.
    /// </summary>
    /// <value>The password of the account.</value>
    public string? Password { get; }

    /// <inheritdoc/>
    public int CompareTo(Account? other) => Name.CompareTo(other?.Name);
}