namespace NGRadio.MenuSystem;

/// <summary>
/// Holds the current history of <see cref="IRenderable"/> instances.
/// </summary>
public record RenderState
{
    private readonly Stack<IRenderable> previous = [];

    /// <summary>
    /// Creates a new instance of the <see cref="RenderState"/> record.
    /// </summary>
    /// <param name="startRender">The first <see cref="IRenderable"/> object to store.</param>
    public RenderState(IRenderable startRender) => Current = startRender;

    /// <summary>
    /// Gets the currently active <see cref="IRenderable"/> object.
    /// </summary>
    public IRenderable? Current { get; private init; }

    /// <summary>
    /// Saves a new <see cref="IRenderable"/> instance to the state record.
    /// </summary>
    /// <param name="render">The render to save.</param>
    public void Save(IRenderable render) => previous.Push(render);

    /// <summary>
    /// Pops the last saved <see cref="IRenderable"/> instance from the state record.
    /// </summary>
    /// <returns>
    /// A new <see cref="RenderState"/> instance with the popped value set to <see cref="Current"/>, 
    /// if any render was saved.
    /// </returns>
    public RenderState Pop()
    {
        previous.TryPop(out IRenderable? render);
        return this with { Current = render };
    }
}