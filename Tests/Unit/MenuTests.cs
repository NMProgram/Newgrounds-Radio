namespace Tests.Unit;

using NGRadio.MenuSystem;

public class MenuTests
{
    class TestButton : IButton
    {
        public string Text => "Testing";

        public IPoppable OnPress(IPoppable state) => state;
    }
    class TestMenu : IMenu
    {
        private readonly ICursor cursor;
        private readonly IButton[] buttons;
        public TestMenu(params IButton[] buttons)
        {
            this.buttons = buttons;
            this.cursor = new MenuCursor(buttons.Length);
        }

        private TestMenu(IButton[] btns, ICursor cursor) : this(btns) => this.cursor = cursor;

        public IContainer Selected => buttons[cursor.Index];

        public IMoveable Move(ICursor.Mover mover) => new TestMenu(buttons, mover(cursor));

        public IPoppable? Pop() => null;

        public void Render() => Console.WriteLine();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(0)]
    public void Selected_ReturnsSelectedContainer(int count)
    {
        // Arrange
        TestButton exp = new();
        var menu = new TestMenu([..Enumerable.Repeat(new TestButton(), count).ToArray(), exp]);
        for (int i = 0; i < count; i++) menu = menu?.Move(c => c.Down) as TestMenu;
        // Act
        IContainer? act = menu?.Selected;
        // Assert
        Assert.Equal(exp, act);
    }
}
