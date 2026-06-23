using System.Text.Json.Serialization;

namespace ZzzBnb.Shared.Core.Validation;

public class ValidationFailure(string propertyName, string errorMessage)
{
    [JsonPropertyName("property_name")]
    public string PropertyName { get; } = propertyName;

    [JsonPropertyName("error_message")]
    public string ErrorMessage { get; } = errorMessage;
}