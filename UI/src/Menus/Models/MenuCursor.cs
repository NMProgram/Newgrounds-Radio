namespace NGRadio.MenuSystem;

using static Logic.IntUtils;

public readonly struct MenuCursor : ICursor
{
    public const int PageSize = 10;

    private readonly int max;

    public MenuCursor(int index, int max) => (this.Index, this.max) = (index, max);

    public int Index { get; }

    public ICursor Up => new MenuCursor(WrapToMax(Index - 1, max, v => v), max);

    public ICursor Left => new MenuCursor(WrapToMax(Index - PageSize, max, v => Floor(v, PageSize)), max);

    public ICursor Down => new MenuCursor(WrapToZero(Index + 1, max, v => v), max);

    public ICursor Right => new MenuCursor(WrapToZero(Index + PageSize, max, v => Floor(v, PageSize)), max);

    public static explicit operator int(MenuCursor cursor) => cursor.Index;
}