namespace NGRadio;

public class Account
{
    public static bool IsValidName(string? name) => !string.IsNullOrWhiteSpace(name) 
        && name.All(char.IsAscii)
        && new Range(3, 30).HasValue(name.Length);
}