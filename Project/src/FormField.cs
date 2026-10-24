namespace NGRadio;

public abstract class FormField<T>
{
    protected T Value { get; }

    public FormField(T value) => Value = value;
    public bool Validate(IValidator<T> validator) => validator.Validate(Value);
}