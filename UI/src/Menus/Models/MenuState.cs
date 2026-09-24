namespace NGRadio.MenuSystem;

/// <summary>
/// Represents the state variables of an <see cref="IMenu"/> instance.
/// </summary>
public record MenuState
{
    /// <summary>
    /// Creates a new instance of the <see cref="MenuState"/> record.
    /// </summary>
    /// <param name="cursor">The cursor position of the menu.</param>
    /// <param name="prev">The previously active menu.</param>
    public MenuState(ICursor cursor, IMenu? prev = null)
    {
        Cursor = cursor;
        Prev = prev;
    }

    /// <inheritdoc cref="MenuState(ICursor, IMenu?)"/>
    /// <param name="options">The total options of the menu.</param>
    public MenuState(int options, IMenu? prev = null)
    : this(new MenuCursor(options), prev) { }

    /// <summary>
    /// Gets or initializes the cursor position of the menu.
    /// </summary>
    public ICursor Cursor { get; init; }

    /// <summary>
    /// Gets or initializes the previously active menu.
    /// </summary>
    public IMenu? Prev { get; init; }
}