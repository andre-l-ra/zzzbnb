namespace ZzzBnb.Shared.Core.Validation
{
    public static class DomainValidation
    {
        public static void NotNull(object? value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(propertyName, $"{propertyName} cannot be null.");
            }
        }       
    }
}