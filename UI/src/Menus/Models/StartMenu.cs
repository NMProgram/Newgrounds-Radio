namespace NGRadio.MenuSystem;

/// <summary>
/// Represents the starting Menu for the Newgrounds Radio system.
/// </summary>
public class StartMenu : IMenu
{
    private static readonly IButton[] buttons = [
        new Button("Option 1", state => state.Pop()),
        new Button("Option 2", state => { Console.WriteLine("Hello!"); Console.ReadLine(); return state; }),
        new Button("Option 3", state => state.Pop()),
    ];

    /// <summary>
    /// Creates a new instance of the <see cref="StartMenu"/> class.
    /// </summary>
    public StartMenu()
    {
    }

    public int ButtonCount => buttons.Length;

    public IButton GetButton(Index index) => buttons[index];

    public void Render() => Array.ForEach(MenuUtils.GetButtonDisplay(buttons, 0), Console.WriteLine);
}