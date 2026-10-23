namespace NGRadio;

public class Account
{
    public static bool IsValidName(string? name) => !string.IsNullOrWhiteSpace(name) 
        && name.All(char.IsAscii)
        && name.Length <= 30
        && name.Length >= 3;
}