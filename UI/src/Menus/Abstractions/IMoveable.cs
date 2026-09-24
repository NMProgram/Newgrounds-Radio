namespace NGRadio.MenuSystem;

/// <summary>
/// Represents an object moveable in the X and Y axes.
/// </summary>
public interface IMoveable
{
    /// <summary>
    /// Moves the current <see cref="IMoveable"/> instance with the provided selector.
    /// </summary>
    /// <param name="mover">The selector to apply to the cursor.</param>
    /// <returns>A new <see cref="IMoveable"/> instance with the moved cursor.</returns>
    IMoveable Move(ICursor.Mover mover);
}