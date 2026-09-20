namespace NGRadio.MenuSystem;

public abstract class Menu : IRenderable, IButtonCollection
{
    private readonly IMenuButton[] buttons;

    protected Menu(IMenuButton[] buttons) => this.buttons = buttons;

    public abstract void Render(int index);

    public IMenuButton GetButton(Index index) => buttons[index];

    public IMenuButton this[Index index] => GetButton(index);

    public int ButtonCount => buttons.Length;
}