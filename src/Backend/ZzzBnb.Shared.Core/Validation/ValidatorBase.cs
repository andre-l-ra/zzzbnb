using System.ComponentModel.DataAnnotations;

namespace ZzzBnb.Shared.Core.Validation;

public abstract class ValidatorBase<T>
{
    protected readonly ValidationResult ValidationResult = new();
    public abstract ValidationResult Validate(T instance);

    private void AddError(string propertyName, string errorMessage)
    {
        ValidationResult.AddFailure(propertyName, errorMessage);
    }

    protected void AddErrorGeneric(string propertyName, string errorMessage)
    {
        AddError(propertyName, errorMessage);
    }

    protected void MustBeTrue(bool value, string propertyName, string errorMessage)
    {
        if (!value)
            AddError(propertyName, errorMessage);
    }
    
    protected void NotEmpty(string value, string propertyName, string message)
    {
        if (string.IsNullOrWhiteSpace(value))
            AddError(propertyName, message);
    }
}