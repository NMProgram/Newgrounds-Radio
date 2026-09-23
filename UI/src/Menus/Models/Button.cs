namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a simple pressable button.
/// </summary>
/// <param name="text">The text on the button.</param>
/// <param name="onPress">The function to invoke upon pressing the button.</param>
public class Button(string text, Func<IPoppable, IPoppable?> onPress) : IButton
{
    public string Text => text;

    public IPoppable? OnPress(IPoppable state) => onPress.Invoke(state);
}