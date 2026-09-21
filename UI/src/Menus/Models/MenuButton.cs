namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a simple pushable button on an <see cref="IMenu"/> instance.
/// </summary>
/// <param name="text">The description of the button.</param>
/// <param name="onPress">The function to invoke upon pressing the button.</param>
public class MenuButton(string text, Func<RenderState, RenderState> onPress) : IMenuButton
{
    public string Text => text;

    public RenderState OnPress(RenderState state) => onPress.Invoke(state);
}