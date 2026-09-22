namespace Tests.Unit;

using NGRadio.MenuSystem;

public class RenderStateTests
{
    class TestRender : IRenderable
    {
        public void Render() => Console.WriteLine();
    }

    [Fact]
    public void Pop_SetsCurrentProperty_PopsFromStack()
    {
        // Arrange
        IRenderable render = new TestRender();
        RenderState state = new RenderState(new TestRender());
        state.Save(render);
        // Act
        var newState = state.Pop();
        // Assert
        Assert.Equal(render, newState.Current);
    }
}
