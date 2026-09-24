namespace NGRadio.MenuSystem;

public interface IMenu : IRenderable, IPoppable, IMoveable
{
    IContainer Selected { get; }
}