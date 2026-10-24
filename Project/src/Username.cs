namespace NGRadio;

public class Username : FormField<string>
{
    private readonly string _name;

    public override string Value => _name;

    public Username(string? name) : base(new UsernameValidator()) => _name = name ?? string.Empty;
}
