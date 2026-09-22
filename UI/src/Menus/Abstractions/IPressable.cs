namespace NGRadio.MenuSystem;

/// <summary>
/// Represents a pressable object.
/// </summary>
public interface IPressable
{
    /// <summary>
    /// Invokes an action after being pressed.
    /// </summary>
    /// <param name="sender">The poppable sender of the invocation.</param>
    /// <returns>A (new) <see cref="IPoppable"/> instance after invoking the action.</returns>
    IPoppable? OnPress(IPoppable sender);
}