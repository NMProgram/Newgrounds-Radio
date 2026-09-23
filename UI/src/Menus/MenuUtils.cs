namespace NGRadio.MenuSystem;

public static class MenuUtils
{
    public static string[] GetOptionDisplay(IContainer[] btns, ICursor cursor) => btns
    .Select(PrefixButton(cursor.Index))
    .ToArray();

    private static Func<IContainer, int, string> PrefixButton(int index) 
        => (btn, i) => $"{(index == i ? '>' : ' ')} {btn.Text}";
}