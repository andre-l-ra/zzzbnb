using System.Text.Json.Serialization;

namespace ZzzBnb.Shared.Core.Validation;

public class ValidationResult
{
    private readonly List<ValidationFailure> _errors = [];
    [JsonPropertyName("errors")]
    public IList<ValidationFailure> Errors => _errors;

    [JsonPropertyName("is_valid")]
    public bool IsValid => _errors.Count == 0;

    [JsonPropertyName("data")]
    public object? Data { get; set; }

    public ValidationResult() { }

    public ValidationResult(IEnumerable<ValidationFailure> failures)
    {
        _errors.AddRange(failures);
    }

    public void AddFailure(string propertyName, string errorMessage)
    {
        _errors.Add(new ValidationFailure(propertyName, errorMessage));
    }

    public void AddFailure(ValidationFailure failure)
    {
        _errors.Add(failure);
    }

    public void AddFailures(IEnumerable<ValidationFailure> failures)
    {
        _errors.AddRange(failures);
    }

    public static ValidationResult Success => new();
}

