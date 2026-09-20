namespace NGRadio.MenuSystem;

public interface IMenuButton
{
    string Text { get; }
    RenderState OnPress(RenderState state);
}