using Day1.Models;
using System.ComponentModel.DataAnnotations;

namespace Day1.Validators
{
    public class DateMatchAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime? date = value as DateTime?;
            if (date == null)
                return new ValidationResult("Date of Birth is required.");

            Student student = (Student)validationContext.ObjectInstance;
            if (student != null && student.Age != null)
            {
                if (DateTime.Now.Year - date.Value.Year != student.Age)
                    return new ValidationResult("Date of Birth does not match the specified Age. Age must be between 18 and 20.");
            }

            return ValidationResult.Success;
        }
    }
}
