namespace NGRadio.MenuSystem;

public record RenderState
{
    private readonly Stack<IRenderable> previous = [];
    public RenderState(IRenderable startRender) => Current = startRender;
    public IRenderable Current { get; private init; }

    public void Save(IRenderable render) => previous.Push(render);
    public RenderState Pop() => this with { Current = previous.Pop() };
}