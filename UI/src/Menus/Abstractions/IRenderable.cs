namespace NGRadio.MenuSystem;

/// <summary>
/// Represents an object capable of rendering.
/// </summary>
public interface IRenderable
{
    /// <summary>
    /// Renders the current <see cref="IRenderable"/> instance.
    /// </summary>
    void Render();
}