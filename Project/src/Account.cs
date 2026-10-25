namespace NGRadio;

/// <summary>
/// Represents a request used to create a user's account.
/// </summary>
public class Account
{
    /// <inheritdoc cref="AccountResponse(string)"/>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public Account(Guid id, string name, string pass)
    {
        ID = id;
        Name = name;
        Password = pass;
    }

    /// <summary>Gets the name of the account.</summary>
    /// <value>The name of the account.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the password of the account.
    /// </summary>
    /// <value>The password of the account.</value>
    public string Password { get; }

    /// <summary>
    /// Gets the ID of the account.
    /// </summary>
    /// <value>The GUID associated with the account.</value>
    public Guid ID { get; }
}