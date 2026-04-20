using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class TotalPricePositiveAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is decimal decimalValue && decimalValue >= 0)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Total Price must be a positive value.");
        }
    }
}
