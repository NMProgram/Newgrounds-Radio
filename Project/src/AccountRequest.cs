namespace NGRadio;

/// <summary>
/// Represents a request used to create a user's account.
/// </summary>
public class AccountRequest : AccountResponse
{
    /// <inheritdoc cref="AccountResponse(string)"/>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public AccountRequest(string name, string pass)
    : base(name)
    {
        Password = pass;
    }
    /// <summary>
    /// Gets the password of the account.
    /// </summary>
    /// <value>The password of the account.</value>
    public string Password { get; }
}
