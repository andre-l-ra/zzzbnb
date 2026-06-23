namespace ZzzBnb.Shared.Core.Validation;

public abstract class ValidationHandler
{
    public abstract void HandleError(ValidationError error);
    public void HandleError(string message)
        => HandleError(new ValidationError(message));
}
