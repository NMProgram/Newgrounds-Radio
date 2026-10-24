using System.Security.Cryptography;
using System.Text;

namespace NGRadio;

public class Base64SHA256Hasher : IHasher
{
    public static readonly Base64SHA256Hasher Default = new Base64SHA256Hasher();
    public string Hash(string pass) => Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(pass)));
}
