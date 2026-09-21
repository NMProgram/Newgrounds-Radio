namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a navigation menu with a collection of pushable buttons.
/// </summary>
public abstract class Menu : IMenu
{
    /// <summary>
    /// Creates a new instance of the <see cref="Menu"/> abstract class.
    /// </summary>
    /// <param name="buttons">The buttons to use for this menu.</param>
    protected Menu(IMenuButton[] buttons) => this.Buttons = buttons;

    /// <summary>
    /// Gets the buttons of this <see cref="Menu"/> instance.
    /// </summary>
    protected IMenuButton[] Buttons { get; }

    /// <summary>
    /// Renders the current <see cref="Menu"/> instance.
    /// </summary>
    /// <param name="index">The index of the button to select in the render.</param>
    public abstract void Render(int index);

    /// <inheritdoc/>
    public IMenuButton GetButton(Index index) => Buttons[index];

    /// <inheritdoc cref="GetButton"/>
    public IMenuButton this[Index index] => GetButton(index);

    /// <summary>
    /// Gets the total amount of buttons in this menu.
    /// </summary>
    public int ButtonCount => Buttons.Length;
}
