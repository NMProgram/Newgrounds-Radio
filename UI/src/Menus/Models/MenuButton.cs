namespace NGRadio.MenuSystem;

public class MenuButton(string text, Func<RenderState, RenderState> onPress) : IMenuButton
{
    public string Text => text;

    public RenderState OnPress(RenderState state) => onPress.Invoke(state);
}