using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class DateNotInFutureAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue && dateValue <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The date cannot be in the future.");
        }
    }
}
