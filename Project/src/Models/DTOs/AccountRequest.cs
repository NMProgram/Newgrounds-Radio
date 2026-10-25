namespace NGRadio.Models.DTOs;

using Models.Entities;

/// <summary>
/// Represents a request used to create a user's account.
/// </summary>
public class AccountRequest
{
    /// <summary>Creates a new instance of the <see cref="AccountRequest"/> class.</summary>
    /// <inheritdoc cref="Account(Guid, string, string)"/>
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
