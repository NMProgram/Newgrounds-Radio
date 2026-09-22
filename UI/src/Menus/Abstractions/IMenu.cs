namespace NGRadio.MenuSystem;

public interface IMenu : IRenderable, IButtonCollection
{
    
}

public interface IMenu2 : IRenderable, IPoppable
{
    IContainer Selected { get; }
    IMenu2 MoveCursor(ICursor.Mover mover);
}