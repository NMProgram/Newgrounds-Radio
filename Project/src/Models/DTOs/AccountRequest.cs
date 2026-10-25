namespace NGRadio.Models.DTOs;

/// <summary>
/// Represents a request used to create a user's account.
/// </summary>
public class AccountRequest
{
    /// <inheritdoc cref="AccountResponse(string)"/>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public AccountRequest(string name, string pass)
    {
        Name = name;
        Password = pass;
    }

    /// <inheritdoc cref="Account.Name"/>
    public string Name { get; }

    /// <inheritdoc cref="Account.Password"/>
    public string Password { get; }
}
