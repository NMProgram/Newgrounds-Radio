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
        private readonly IButton[] buttons;
        public TestMenu(params TestButton[] buttons) => this.buttons = buttons;

        public int ButtonCount => buttons.Length;

        public IButton GetButton(Index index) => buttons[index];

        public void Render() => Console.WriteLine();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(0)]
    public void ButtonCount_ReturnsTotalButtons(int count)
    {
        // Arrange
        var menu = new TestMenu(Enumerable.Repeat(new TestButton(), count).ToArray());
        // Act
        int act = menu.ButtonCount;
        // Assert
        Assert.Equal(count, act);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(0)]
    public void GetButton_ReturnsButtonAtIndex(int count)
    {
        // Arrange
        TestButton exp = new();
        var menu = new TestMenu([exp, ..Enumerable.Repeat(new TestButton(), count).ToArray()]);
        // Act
        IButton act = menu.GetButton(0);
        // Assert
        Assert.Equal(exp, act);
    }
}
