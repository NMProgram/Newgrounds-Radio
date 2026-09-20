namespace NGRadio.MenuSystem;

public interface IButtonCollection
{
    int ButtonCount { get; }
    IMenuButton this[int index] { get; }
}