namespace NGRadio.MenuSystem;

public static class MenuUtils
{
    public static string[] GetButtonDisplay(IButton[] btns, int index) => btns
    .Select(PrefixButton(index))
    .ToArray();

    private static Func<IButton, int, string> PrefixButton(int index) 
        => (btn, i) => $"{(index == i ? '>' : ' ')} {btn.Text}";
}