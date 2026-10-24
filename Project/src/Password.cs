namespace NGRadio;

public class Password : FormField<string>
{
    private readonly string _pass;

    public override string Value => Base64SHA256Hasher.Default.Hash(_pass);

    public Password(string? pass) : base(PasswordValidator.Default) => _pass = pass ?? string.Empty;

    public override bool Validate() => _validator.Validate(_pass);
}
