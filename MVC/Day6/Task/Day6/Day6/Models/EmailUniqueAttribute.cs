using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class EmailUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string email)
            {
                Day6Context Context = new Day6Context();
                var EmailExists = Context.Customers.Any(c => c.Email == email && c.ID != ((Customer)validationContext.ObjectInstance).ID);
                if (EmailExists)
                    return new ValidationResult("Email already exists.");
                else
                    return ValidationResult.Success;
            }

            return new ValidationResult("Invalid email format.");

        }
    }
}
