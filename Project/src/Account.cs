namespace NGRadio;

/// <summary>
/// Represents a user's account.
/// </summary>
public class Account
{
    /// <summary>
    /// The name of the account.
    /// </summary>
    public string Name;

    /// <summary>
    /// Creates a new instance of the <see cref="Account"/> class.
    /// </summary>
    /// <param name="name"><inheritdoc cref="Name" path="/summary"/></param>
    public Account(string name)
    {
        Name = name;
    }
}