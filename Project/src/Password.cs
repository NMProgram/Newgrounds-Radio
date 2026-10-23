using System.Security.Cryptography;
using System.Text;

namespace NGRadio;

public class Password
{
    private readonly string _pass;

    public string GetHash() => Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(_pass)));

    public Password(string? pass) => _pass = pass ?? string.Empty;

    public bool Validate() => !string.IsNullOrWhiteSpace(_pass)
        && new Range(8, 120).HasValue(_pass.Length)
        && _pass.All(char.IsAscii)
        && _pass.Any(c => char.IsPunctuation(c) || char.IsSymbol(c))
        && _pass.Any(char.IsUpper)
        && _pass.Any(char.IsLower)
        && _pass.Any(char.IsDigit);
}
