namespace NGRadio;

public class Range
{
    private readonly int _min;
    private readonly int _max;

    public Range(int min, int max)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThan(min, max);
        _min = min;
        _max = max;
    }

    public bool HasValue(int value) => value >= _min && value <= _max;
}