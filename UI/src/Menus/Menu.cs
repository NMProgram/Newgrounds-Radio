namespace NGRadio.MenuSystem;

public abstract class Menu : IRenderable, IButtonCollection
{
    protected Menu(IMenuButton[] buttons) => this.Buttons = buttons;

    protected IMenuButton[] Buttons { get; }

    public abstract void Render(int index);

    public IMenuButton GetButton(Index index) => Buttons[index];

    public IMenuButton this[Index index] => GetButton(index);

    public int ButtonCount => Buttons.Length;
}