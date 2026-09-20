namespace NGRadio.MenuSystem;

public interface IButtonCollection
{
    int ButtonCount { get; }
    IMenuButton GetButton(Index index);
}