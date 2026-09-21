namespace NGRadio.MenuSystem;

public static class MenuRunner
{
    public static void Start(IMenu menu)
    {
        MenuPos pos = new MenuPos(menu.ButtonCount);
        RenderState state = new RenderState(menu);
        while (state.Current is not null)
        {
            state.Current.Render(pos.Value);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter: state = menu.GetButton(pos.Value).OnPress(state); break;
                case ConsoleKey.Backspace: state = state.Pop(); break;
                default: pos = UpdatePosLimit(MovePosition(pos, keyInfo.Key), state); break;
            }
        }
    }

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