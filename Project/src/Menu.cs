namespace NGRadio;

public class Menu
{
    private readonly string? header;
    private readonly string[] options;

    public Menu(string? header, string[] options)
    {
        ArgumentNullException.ThrowIfNull(options);
        if (options.Length == 0) throw OptionsEmpty(nameof(options));

        this.header = header;
        this.options = options;
    }

    public string Render() => $"""
    {header}
    {string.Join("\r\n", options)}
    """;

    private static ArgumentException OptionsEmpty(string paramName) 
        => new ArgumentException("A menu must have at least one option.", paramName);
}