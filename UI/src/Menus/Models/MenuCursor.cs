namespace NGRadio.MenuSystem;

using static Logic.IntUtils;

public readonly struct MenuCursor : ICursor
{
    public const int PageSize = 10;

    private readonly int max;
    private readonly int index;

    public MenuCursor(int index, int max) => (this.index, this.max) = (index, max);

    public ICursor Up => new MenuCursor(WrapToMax(index - 1, max, v => v), max);

    public ICursor Left => new MenuCursor(WrapToMax(index - PageSize, max, v => Floor(v, PageSize)), max);

    public ICursor Down => new MenuCursor(WrapToZero(index + 1, max, v => v), max);

    public ICursor Right => new MenuCursor(WrapToZero(index + PageSize, max, v => Floor(v, PageSize)), max);

    public static explicit operator int(MenuCursor cursor) => cursor.index;
}