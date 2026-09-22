namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a pressable button in the <see cref="Menu"/> class.
/// </summary>
public interface IMenuButton : IContainer
{
    /// <summary>
    /// Activates the button using previously saved renders.
    /// </summary>
    /// <param name="state">The state of the renders.</param>
    /// <returns>A (possibly) modified copy of the <see cref="RenderState"/> instance.</returns>
    RenderState OnPress(RenderState state);
}