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
    public static void Start(IMenu2? menu)
    {
        while (menu is not null)
        {
            Console.Clear();
            menu.Render();
            menu = ProcessInput(menu) as IMenu2;
        }
    }

    private static IPoppable? ProcessInput(IMenu2 menu)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        return keyInfo.Key switch
        {
            ConsoleKey.Enter when menu.Selected is IPressable btn => btn.OnPress(menu),
            ConsoleKey.Backspace => menu.Pop(),
            _ => MovePosition(menu, keyInfo.Key)
        };
    }

    private static IMenu2 MovePosition(IMenu2 m, ConsoleKey key) => key switch
    {
        ConsoleKey.W or ConsoleKey.UpArrow => m.MoveCursor(c => c.Up),
        ConsoleKey.S or ConsoleKey.DownArrow => m.MoveCursor(c => c.Down),
        ConsoleKey.D or ConsoleKey.RightArrow => m.MoveCursor(c => c.Right),
        ConsoleKey.A or ConsoleKey.LeftArrow => m.MoveCursor(c => c.Left),
        _ => m
    };
}
