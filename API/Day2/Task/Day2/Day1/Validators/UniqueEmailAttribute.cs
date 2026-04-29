using Day1.Models;
using System.ComponentModel.DataAnnotations;

namespace Day1.Validators
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? email = value as string;
            if (email == null)
                return new ValidationResult("Email is required.");

            var student = (Student)validationContext.ObjectInstance;
            StudentContext context = new StudentContext();
            if (student.ID == 0)
            {
                var existingStudent = context.Students.FirstOrDefault(s => s.Email == email);
                if (existingStudent != null)
                    return new ValidationResult("Email must be unique.");
            }
            else {
                var existingStudent = context.Students.FirstOrDefault(s => s.Email == email && s.ID != student.ID);
                if (existingStudent != null)
                    return new ValidationResult("Email must be unique.");
            }

            return ValidationResult.Success;
        }
    }
}
