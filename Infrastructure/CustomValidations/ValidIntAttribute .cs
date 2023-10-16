using System.ComponentModel.DataAnnotations;

namespace Infrastructure.CustomValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class ValidIntAttribute : ValidationAttribute
    {
        public ValidIntAttribute()
        {
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string stringValue && int.TryParse(stringValue, out _) || value is int)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "El campo no es un número entero válido (int).");
        }
    }
}
