namespace NGRadio.MenuSystem;

/// <summary>
/// Provides a way to run an <see cref="IMenu"/> instance.
/// </summary>
public static class MenuRunner
{
    /// <summary>
    /// Starts the <see cref="MenuRunner"/> 
    /// with the provided <see cref="IMenu"/> instance.
    /// </summary>
    /// <param name="menu">The menu to start running.</param>
    public static void Start(IMenu menu)
    {
        MenuPos pos = new MenuPos(menu.ButtonCount);
        RenderState state = new RenderState(menu);
        while (state.Current is not null)
        {
            state.Current.Render(pos.Value);
            (pos, state) = ProcessInput(pos, state);
            pos = UpdatePosLimit(pos, state);
        }
    }

    private static (MenuPos, RenderState) ProcessInput(MenuPos pos, RenderState state)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        return keyInfo.Key switch
        {
            ConsoleKey.Enter => (pos, PressButtonAt(pos, state)),
            ConsoleKey.Backspace => (pos, state.Pop()),
            _ => (MovePosition(pos, keyInfo.Key), state)
        };
    }

    private static RenderState PressButtonAt(MenuPos pos, RenderState state) => 
    ((IButtonCollection)state.Current!)
    .GetButton(pos.Value)
    .OnPress(state);

    private static MenuPos MovePosition(MenuPos pos, ConsoleKey key) => key switch
    {
        ConsoleKey.W or ConsoleKey.UpArrow => pos.MoveUp(),
        ConsoleKey.S or ConsoleKey.DownArrow => pos.MoveDown(),
        ConsoleKey.D or ConsoleKey.RightArrow => pos.MoveRight(),
        ConsoleKey.A or ConsoleKey.LeftArrow => pos.MoveLeft(),
        _ => pos
    };

    private static MenuPos UpdatePosLimit(MenuPos pos, RenderState state) 
        => pos with { Max = ((IButtonCollection)state.Current!).ButtonCount };
}
