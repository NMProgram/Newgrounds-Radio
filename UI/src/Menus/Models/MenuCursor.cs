namespace NGRadio.MenuSystem;

using static Logic.IntUtils;

/// <summary>
/// Represents a wrappable cursor for navigating a menu system.
/// </summary>
public readonly struct MenuCursor : ICursor
{
    /// <summary>
    /// The total results to show per page of the menu.
    /// </summary>
    public const int PageSize = 10;

    private readonly int max;

    /// <inheritdoc cref="MenuCursor(int, int)"/>
    public MenuCursor(int max) => this.max = max;

    /// <summary>
    /// Creates a new instance of the <see cref="MenuCursor"/> struct.
    /// </summary>
    /// <param name="index">The start index of the cursor.</param>
    /// <param name="max">The maximum value to wrap the cursor around.</param>
    public MenuCursor(int index, int max) : this(max) => this.Index = index;

    /// <summary>
    /// Gets the current index of the <see cref="MenuCursor"/> instance.
    /// </summary>
    public int Index { get; private init; }

    /// <summary>
    /// Moves the <see cref="MenuCursor"/> instance upwards.
    /// </summary>
    /// <returns>A new <see cref="MenuCursor"/> instance with the updated index.</returns>
    public ICursor Up => this with { Index = WrapToMax(Index - 1, max, v => v) };

    /// <summary>
    /// Moves the <see cref="MenuCursor"/> instance to the left.
    /// </summary>
    /// <returns><inheritdoc cref="Up"/></returns>
    public ICursor Left => this with { Index = WrapToMax(Index - PageSize, max, v => Floor(v, PageSize)) };

    /// <summary>
    /// Moves the <see cref="MenuCursor"/> instance downwards.
    /// </summary>
    /// <returns><inheritdoc cref="Up"/></returns>
    public ICursor Down => this with { Index = WrapToZero(Index + 1, max, v => v) };

    /// <summary>
    /// Moves the <see cref="MenuCursor"/> instance to the right.
    /// </summary>
    /// <returns><inheritdoc cref="Up"/></returns>
    public ICursor Right => this with { Index = WrapToZero(Index + PageSize, max, v => Floor(v, PageSize)) };
}