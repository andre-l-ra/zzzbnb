namespace ZzzBnb.Shared.Core.Validation;

public abstract class Validator
{
    protected readonly ValidationHandler Handler;

    protected Validator(ValidationHandler handler) 
        => Handler = handler;

    public abstract void Validate();
}