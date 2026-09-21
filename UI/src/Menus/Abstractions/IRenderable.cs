namespace NGRadio.MenuSystem;

/// <summary>
/// Represents an object capable of rendering an array.
/// </summary>
public interface IRenderable
{
    /// <summary>
    /// Renders the current <see cref="IRenderable"/> instance.
    /// </summary>
    /// <param name="index">The array position to use for rendering.</param>
    void Render(int index);
}