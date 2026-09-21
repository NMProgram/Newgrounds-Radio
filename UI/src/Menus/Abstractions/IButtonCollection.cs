namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a collection of <see cref="IMenuButton"/> instances.
/// </summary>
public interface IButtonCollection
{
    /// <summary>
    /// Gets the count of the buttons in the collection.
    /// </summary>
    int ButtonCount { get; }

    /// <summary>
    /// Gets a button in the collection by index.
    /// </summary>
    /// <param name="index">The index to use to get a button from the collection.</param>
    /// <returns>The found button from the collection.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the index falls outside of the collection's range.</exception>
    IMenuButton GetButton(Index index);
}