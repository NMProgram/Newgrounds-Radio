namespace NGRadio;

public class Password : FormField<string>
{
    public Password(string? pass) : base(pass ?? string.Empty) { }

    public string Hash(IHasher hasher) => hasher.Hash(Value);
}
