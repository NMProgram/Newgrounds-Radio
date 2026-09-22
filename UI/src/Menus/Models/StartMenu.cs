namespace NGRadio.MenuSystem;

/// <summary>
/// Represents the starting Menu for the Newgrounds Radio system.
/// </summary>
public class StartMenu : IMenu2
{
    private readonly ICursor cursor = new MenuCursor(buttons.Length);
    private static readonly IButton[] buttons = [
        new Button("Option 1", state => state.Pop()),
        new Button("Option 2", state => { Console.WriteLine("Hello!"); Console.ReadLine(); return state; }),
        new Button("Option 3", state => state.Pop()),
    ];

    /// <summary>
    /// Creates a new instance of the <see cref="StartMenu"/> class.
    /// </summary>
    public StartMenu() { }

    private StartMenu(ICursor cursor) => this.cursor = cursor;

    public IContainer Selected => buttons[cursor.Index];

    public IMenu2 MoveCursor(ICursor.Mover mover) => new StartMenu(mover(cursor));

    public IPoppable? Pop() => null;

    public void Render() => Array.ForEach(MenuUtils.GetButtonDisplay(buttons, cursor.Index), Console.WriteLine);
}