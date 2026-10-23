namespace NGRadio;

public class Username
{
    private readonly string? _name;

    public Username(string? name) => _name = name;

    public bool Validate() => !string.IsNullOrEmpty(_name)
        && new Range(3, 30).HasValue(_name.Length)
        && _name.All(c => char.IsAsciiLetterOrDigit(c) || c == '-' || c == '_')
        && !_name.EndsWith('-')
        && !_name.EndsWith('_');
}
