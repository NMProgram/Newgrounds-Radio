namespace NGRadio;

public class UsernameValidator : IValidator<string>
{
    public bool Validate(string? name) => !string.IsNullOrEmpty(name)
        && new Range(3, 30).HasValue(name.Length)
        && name.All(c => char.IsAsciiLetterOrDigit(c) || c == '-' || c == '_')
        && !name.EndsWith('-')
        && !name.EndsWith('_');
}