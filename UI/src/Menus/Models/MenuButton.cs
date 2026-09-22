namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a simple pushable button on an <see cref="IMenu"/> instance.
/// </summary>
/// <param name="text">The description of the button.</param>
/// <param name="onPress">The function to invoke upon pressing the button.</param>
public class MenuButton(string text, Func<IPoppable, IPoppable?> onPress) : IMenuButton
{
    public string Text => text;

    public IPoppable? OnPress(IPoppable state) => onPress.Invoke(state);
}