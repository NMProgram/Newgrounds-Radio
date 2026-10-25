namespace NGRadio;

/// <summary>
/// Represents a request used to create a user's account.
/// </summary>
public class Account : AccountRequest
{
    /// <inheritdoc cref="AccountResponse(string)"/>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public Account(Guid id, string name, string pass)
    : base(name, pass)
    {
        ID = id;
    }

    /// <summary>
    /// Gets the ID of the account.
    /// </summary>
    /// <value>The GUID associated with the account.</value>
    public Guid ID { get; }
}