namespace NGRadio;

public interface IValidator<in T>
{
    bool Validate(T? value);
}
