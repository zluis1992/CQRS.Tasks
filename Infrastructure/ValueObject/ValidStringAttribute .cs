using System.ComponentModel.DataAnnotations;

namespace Infrastructure.ValueObject
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class ValidStringAttribute : ValidationAttribute
    {
        public ValidStringAttribute()
        {
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? customErrorMessage = ErrorMessage;

            if (value is string)
            {
                return ValidationResult.Success;
            }

            if (string.IsNullOrEmpty(customErrorMessage))
            {
                customErrorMessage = "El campo no es una cadena válida.";
            }

            return new ValidationResult(customErrorMessage);
        }
    }
}
