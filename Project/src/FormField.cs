namespace NGRadio;

public abstract class FormField<T>
{
    protected readonly IValidator<T> _validator;

    public FormField(IValidator<T> validator) => _validator = validator;

    public abstract T Value { get; }

    public virtual bool Validate() => _validator.Validate(Value);
}