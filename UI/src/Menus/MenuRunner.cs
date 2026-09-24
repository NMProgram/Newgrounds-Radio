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
    public static void Start(IMenu? menu)
    {
        while (menu is not null)
        {
            Console.Clear();
            menu.Render();
            menu = HandleKeyPress(menu) as IMenu;
        }
    }

    private static IPoppable? HandleKeyPress(IMenu menu) => Console.ReadKey().Key switch
    {
        ConsoleKey.Enter when menu.Selected is IPressable btn => btn.OnPress(menu),
        ConsoleKey.Backspace => menu.Pop(),

        ConsoleKey.W or ConsoleKey.UpArrow => (IPoppable)menu.Move(c => c.Up),
        ConsoleKey.S or ConsoleKey.DownArrow => (IPoppable)menu.Move(c => c.Down),
        ConsoleKey.D or ConsoleKey.RightArrow => (IPoppable)menu.Move(c => c.Right),
        ConsoleKey.A or ConsoleKey.LeftArrow => (IPoppable)menu.Move(c => c.Left),
        _ => menu
    };
}
