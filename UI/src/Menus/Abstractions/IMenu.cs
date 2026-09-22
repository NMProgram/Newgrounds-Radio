namespace NGRadio.MenuSystem;

public interface IMenu : IRenderable, IPoppable
{
    IContainer Selected { get; }
    IMenu MoveCursor(ICursor.Mover mover);
}