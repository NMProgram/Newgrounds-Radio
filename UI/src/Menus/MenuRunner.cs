namespace NGRadio.MenuSystem;

public static class MenuRunner
{
    public static void Start(IMenu menu)
    {
        MenuPos pos = new MenuPos(menu.ButtonCount);
        RenderState state = new RenderState(menu);
        do
        {
            pos = pos with { Max = ((IButtonCollection)state.Current!).ButtonCount };
            state.Current?.Render(pos.Value);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter: state = menu.GetButton(pos.Value).OnPress(state); break;
                case ConsoleKey.Backspace: state = state.Pop(); break;
                default: MovePosition(pos, keyInfo.Key); break;
            }
        }
        while(state.Current is not null);
    }

    private static int MovePosition(MenuPos pos, ConsoleKey key) => key switch
    {
        ConsoleKey.W or ConsoleKey.UpArrow => pos.MoveUp(),
        ConsoleKey.S or ConsoleKey.DownArrow => pos.MoveDown(),
        ConsoleKey.D or ConsoleKey.RightArrow => pos.MoveRight(),
        ConsoleKey.A or ConsoleKey.LeftArrow => pos.MoveLeft(),
        _ => pos.Value
    };
}