namespace NGRadio.MenuSystem;

/// <summary>
/// Represents an object with a previous object.
/// </summary>
public interface IPoppable
{
    /// <summary>
    /// Pops the previous <see cref="IPoppable"/> instance
    /// from the current <see cref="IPoppable"/> instance.
    /// </summary>
    /// <returns>The <see cref="IPoppable"/> instance if found after popping, <see cref="null"/> otherwise.</returns>
    IPoppable? Pop();
}