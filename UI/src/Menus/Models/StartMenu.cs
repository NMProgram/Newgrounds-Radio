namespace NGRadio.MenuSystem;

/// <summary>
/// Represents the starting Menu for the Newgrounds Radio system.
/// </summary>
public class StartMenu : IMenu
{
    private readonly MenuState state = new MenuState(options.Length);
    private static readonly IContainer[] options = [
        new Button("Option 1", state => state.Pop()),
        new Button("Option 2", state => { Console.WriteLine("Hello!"); Console.ReadLine(); return state; }),
        new Button("Option 3", state => state.Pop()),
    ];

    /// <summary>
    /// Creates a new instance of the <see cref="StartMenu"/> class.
    /// </summary>
    public StartMenu() { }

    private StartMenu(MenuState state) => this.state = state;

    public IContainer Selected => options[state.Cursor.Index];

    public IMoveable Move(ICursor.Mover mover) => new StartMenu(state with { Cursor = mover(state.Cursor) });

    public IPoppable? Pop() => null;

    public void Render() => Array.ForEach(MenuUtils.GetOptionDisplay(options, state.Cursor), Console.WriteLine);
}