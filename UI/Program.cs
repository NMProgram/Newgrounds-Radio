namespace NGRadio;

using NGRadio.MenuSystem;

static class Program
{
    static void Main(string[] args)
    {
        MenuRunner.Start(new StartMenu());
    }
}
