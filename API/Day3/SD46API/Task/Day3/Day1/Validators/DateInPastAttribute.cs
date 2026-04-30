using System.ComponentModel.DataAnnotations;

namespace Day1.Validators
{
    public class DateInPastAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
         
            var date = value as DateTime?;
            if (date == null)
                return new ValidationResult("Date is required.");
            if (date > DateTime.Now)
                return new ValidationResult("Date must be in the past.");
            return ValidationResult.Success;
        }
    }
}
