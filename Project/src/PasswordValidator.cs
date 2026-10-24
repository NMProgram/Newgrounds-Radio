namespace NGRadio;

public class PasswordValidator : IValidator<string>
{
    public bool Validate(string? pass) => !string.IsNullOrEmpty(pass)
        && new Range(8, 120).HasValue(pass.Length)
        && pass.All(char.IsAscii)
        && pass.Any(c => char.IsPunctuation(c) || char.IsSymbol(c))
        && pass.Any(char.IsUpper)
        && pass.Any(char.IsLower)
        && pass.Any(char.IsDigit);
}
