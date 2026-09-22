namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a moveable cursor on the X- and Y-axis.
/// </summary>
public interface ICursor
{
    /// <summary>
    /// Delegates a provided <see cref="ICursor"/> instance to a new position.
    /// </summary>
    /// <param name="cursor">The cursor object to move.</param>
    /// <returns>The delegated <see cref="ICursor"/> instance.</returns>
    delegate ICursor Mover(ICursor cursor);

    /// <summary>
    /// Gets the current index of the <see cref="ICursor"/> instance.
    /// </summary>
    int Index { get; }

    /// <summary>
    /// Gets a new <see cref="ICursor"/> instance moved upwards.
    /// </summary>
    ICursor Up { get; }

    /// <summary>
    /// Gets a new <see cref="ICursor"/> instance moved to the left.
    /// </summary>
    ICursor Left { get; }

    /// <summary>
    /// Gets a new <see cref="ICursor"/> instance moved downwards.
    /// </summary>
    ICursor Down { get; }

    /// <summary>
    /// Gets a new <see cref="ICursor"/> instance moved to the right.
    /// </summary>
    ICursor Right { get; }
}