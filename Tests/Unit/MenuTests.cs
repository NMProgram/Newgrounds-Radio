namespace Tests.Unit;

using NGRadio.MenuSystem;

public class MenuTests
{
    class TestButton : IButton
    {
        public string Text => "Testing";

        public IPoppable OnPress(IPoppable state) => state;
    }
    class TestMenu : Menu
    {
        public TestMenu(params TestButton[] buttons) : base(buttons) { }

        public override void Render() => Console.WriteLine();
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
        IButton act = menu[0];
        // Assert
        Assert.Equal(exp, act);
    }
}
