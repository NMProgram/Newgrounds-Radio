namespace NGRadio;
public class Menu
{
    private readonly string header;
    private readonly string[] options;

    public Menu(string header, string[] options)
    {
        this.header = header;
        this.options = options;
    }

    public string Render() => $"""
    {header}
    {string.Join("\r\n", options)}
    """;
}