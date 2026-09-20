namespace NGRadio.Logic;

public static class IntUtils
{
    /// <summary>
    /// Removes all remainders of an integer through integer division.
    /// </summary>
    /// <param name="value">The value to floor.</param>
    /// <param name="divisor">The divisor to use for flooring.</param>
    /// <returns>The floored integer.</returns>
    public static int Floor(int value, int divisor) => value / divisor * divisor;

    /// <summary>
    /// Wraps the integer to zero.
    /// </summary>
    /// <param name="value">The value to wrap.</param>
    /// <param name="max">The maximum to compare the integer to.</param>
    /// <param name="onBelowMax">The selector to use if the value was below the maximum.</param>
    /// <returns>0 if the value was above the maximum, otherwise the converted integer.</returns>
    public static int WrapToZero(int value, int max, Func<int, int> onBelowMax) => value < max ? onBelowMax(value) : 0;

    /// <summary>
    /// Wraps the integer to a maximum.
    /// </summary>
    /// <param name="value">The value to wrap.</param>
    /// <param name="max">The maximum to compare the integer to.</param>
    /// <param name="onPositive">The selector to use if the value was positive.</param>
    /// <returns>The maximum value minus 1 if the value was positive, otherwise the converted integer.</returns>
    public static int WrapToMax(int value, int max, Func<int, int> onPositive) => value >= 0 ? onPositive(value) : max - 1;
}
