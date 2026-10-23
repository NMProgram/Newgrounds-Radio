namespace NGRadio;

public class Account
{
    public static bool IsValidName(string? name) => !string.IsNullOrWhiteSpace(name) 
        && new Range(3, 30).HasValue(name.Length)
        && name.All(c => char.IsAsciiLetterOrDigit(c) || c == '-' || c == '_')
        && !name.EndsWith('-')
        && !name.EndsWith('_');
    
    public static bool IsValidPassword(string? pass) => !string.IsNullOrWhiteSpace(pass)
        && new Range(8, 120).HasValue(pass.Length)
        && pass.Any(c => char.IsPunctuation(c) || char.IsSymbol(c))
        && pass.Any(char.IsUpper)
        && pass.Any(char.IsLower)
        && pass.Any(char.IsDigit)
        && pass.All(char.IsAscii);
}