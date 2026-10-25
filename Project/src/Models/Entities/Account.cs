namespace NGRadio.Models.Entities;

/// <summary>
/// Represents a user's account.
/// </summary>
public class Account
{
    /// <summary>
    /// Creates a new instance of the <see cref="Account"/> class.
    /// </summary>
    /// <param name="id"><inheritdoc cref="ID" path="/value"/></param>
    /// <param name="name"><inheritdoc cref="Name" path="/value"/></param>
    /// <param name="pass"><inheritdoc cref="Password" path="/value"/></param>
    public Account(Guid id, string name, string pass)
    {
        ID = id;
        Name = name;
        Password = pass;
    }

    /// <summary>
    /// Gets the ID of the account.
    /// </summary>
    /// <value>The GUID associated with the account.</value>
    public Guid ID { get; }

    /// <summary>Gets the name of the account.</summary>
    /// <value>The name of the account.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the password of the account.
    /// </summary>
    /// <value>The password of the account.</value>
    public string Password { get; }

}