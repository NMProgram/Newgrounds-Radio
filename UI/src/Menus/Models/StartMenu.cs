namespace NGRadio.MenuSystem;

/// <summary>
/// Represents the starting Menu for the Newgrounds Radio system.
/// </summary>
public class StartMenu : Menu
{
    private static readonly IMenuButton[] buttons = [
        new MenuButton("Option 1", state => state),
        new MenuButton("Option 2", state => state),
        new MenuButton("Option 3", state => state),
    ];

    /// <summary>
    /// Creates a new instance of the <see cref="StartMenu"/> class.
    /// </summary>
    public StartMenu() : base(buttons)
    {
    }

    public override void Render(int index) => Array.ForEach(GetPrefixedText(index), Console.WriteLine);

    private string[] GetPrefixedText(int index) => Buttons
    .Select(GetPrefixedButton(index))
    .ToArray();

    private static Func<IMenuButton, int, string> GetPrefixedButton(int index) 
        => (btn, i) => $"{(index == i ? '>' : ' ')} {btn.Text}";
}