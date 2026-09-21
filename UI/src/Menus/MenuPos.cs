namespace NGRadio.MenuSystem;

using static Logic.IntUtils;

/// <summary>
/// Represents a moveable position for navigating a menu system.
/// </summary>
public struct MenuPos
{
    /// <summary>
    /// The total results to show per page of the menu.
    /// </summary>
    public const int PageCount = 10;

    /// <summary>
    /// Creates a new instance of the <see cref="MenuPos"/> struct.
    /// </summary>
    /// <param name="value">The start index of the position.</param>
    /// <param name="max">The maximum value to wrap the position around.</param>
    public MenuPos(int value, int max) => (this.Value, this.Max) = (value, max);

    /// <inheritdoc cref="MenuPos(int, int)"/>
    public MenuPos(int max) : this(0, max) { }

    /// <summary>
    /// Gets or initializes the maximum value to wrap the position around.
    /// </summary>
    public int Max { get; init; }

    /// <summary>
    /// Gets the current index of the position.
    /// </summary>
    public int Value { get; private init; }

    /// <summary>
    /// Moves the menu position upwards.
    /// </summary>
    /// <returns>A new <see cref="MenuPos"/> instance with the updated index.</returns>
    public MenuPos MoveUp() => this with { Value = WrapToMax(Value - 1, Max, v => v) };

    /// <summary>
    /// Moves the menu position downwards.
    /// </summary>
    /// <returns><inheritdoc cref="MoveUp"/></returns>
    public MenuPos MoveDown() => this with { Value = WrapToZero(Value + 1, Max, v => v) };

    /// <summary>
    /// Moves the menu position to the left, using the set PageCount and flooring.
    /// </summary>
    /// <returns><inheritdoc cref="MoveUp"/></returns>
    public MenuPos MoveLeft() => this with { Value = WrapToMax(Value - PageCount, Max, FloorPageCount) };

    /// <summary>
    /// Moves the menu position to the right, using the set PageCount and flooring.
    /// </summary>
    /// <returns><inheritdoc cref="MoveUp"/></returns>
    public MenuPos MoveRight() => this with { Value = WrapToZero(Value + PageCount, Max, FloorPageCount) };

    private static int FloorPageCount(int value) => Floor(value, PageCount);
}