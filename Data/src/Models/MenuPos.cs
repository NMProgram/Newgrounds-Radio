namespace NGRadio.Models;

using static Logic.IntUtils;

public struct MenuPos
{
    public const int PageCount = 10;
    public MenuPos(int value, int max) => (this.Value, this.Max) = (value, max);
    public MenuPos(int max) : this(0, max) { }

    public int Max { get; init; }
    public int Value { get; private set; }

    public int MoveUp() => Value = WrapToMax(Value - 1, Max, v => v);
    public int MoveDown() => Value = WrapToZero(Value + 1, Max, v => v);
    public int MoveLeft() => Value = WrapToMax(Value - PageCount, Max, FloorPageCount);
    public int MoveRight() => Value = WrapToZero(Value + PageCount, Max, FloorPageCount);

    private static int FloorPageCount(int value) => Floor(value, PageCount);
}