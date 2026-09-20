namespace Tests.Unit;
using NGRadio.MenuSystem;

class TestRender : IRenderable
{
    public void Render(int index)
    {
        Console.WriteLine(index);
    }
}

public class RenderStateTests
{
    [Fact]
    public void Pop_SetsCurrentProperty_PopsFromStack()
    {
        // Arrange
        IRenderable render = new TestRender();
        IRenderable render2 = new TestRender();
        RenderState state = new RenderState(render);
        state.Save(render2);
        // Act
        bool equalToRender = render == state.Current;
        var newState = state.Pop();
        // Assert
        Assert.True(equalToRender, "State was not initialized correctly.");
        Assert.Equal(render2, newState.Current);
        Assert.Throws<InvalidOperationException>(state.Pop);
    }
}
