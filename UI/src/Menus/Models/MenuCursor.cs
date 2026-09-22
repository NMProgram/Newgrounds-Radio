namespace NGRadio.MenuSystem;

using static Logic.IntUtils;

public readonly struct MenuCursor : ICursor
{
    public const int PageSize = 10;

    private readonly int max;

    public MenuCursor(int max) => this.max = max;
    public MenuCursor(int index, int max) : this(max) => this.Index = index;

    public int Index { get; private init; }

    public ICursor Up => this with { Index = WrapToMax(Index - 1, max, v => v) };

    public ICursor Left => this with { Index = WrapToMax(Index - PageSize, max, v => Floor(v, PageSize)) };

    public ICursor Down => this with { Index = WrapToZero(Index + 1, max, v => v) };

    public ICursor Right => this with { Index = WrapToZero(Index + PageSize, max, v => Floor(v, PageSize)) };
}