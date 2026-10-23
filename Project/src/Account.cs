namespace NGRadio;

public class Account
{
    public static bool IsValidName(string? name) => !string.IsNullOrWhiteSpace(name) 
        && new Range(3, 30).HasValue(name.Length)
        && name.All(char.IsAsciiLetterOrDigit);
}