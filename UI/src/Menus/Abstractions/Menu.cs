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
    protected Menu(IButton[] buttons) => this.Buttons = buttons;

    /// <summary>
    /// Gets the buttons of this <see cref="Menu"/> instance.
    /// </summary>
    protected IButton[] Buttons { get; }

    /// <summary>
    /// Renders the current <see cref="Menu"/> instance.
    /// </summary>
    public abstract void Render();

    /// <inheritdoc/>
    public IButton GetButton(Index index) => Buttons[index];

    /// <inheritdoc cref="GetButton"/>
    public IButton this[Index index] => GetButton(index);

    /// <summary>
    /// Gets the total amount of buttons in this menu.
    /// </summary>
    public int ButtonCount => Buttons.Length;
}
