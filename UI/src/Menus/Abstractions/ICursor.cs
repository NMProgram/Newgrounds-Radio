namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a moveable cursor on the X- and Y-axis.
/// </summary>
public interface ICursor
{
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