using System.ComponentModel.DataAnnotations;

namespace Day6.Models
{
    public class PhoneNumberUniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string phone)
            {
                Day6Context Context = new Day6Context();
                var PhoneExists = Context.Customers.Any(c => c.PhoneNum == phone && c.ID != ((Customer)validationContext.ObjectInstance).ID);
                if (PhoneExists)
                    return new ValidationResult("Phone number already exists.");
                else
                    return ValidationResult.Success;
            }

            return new ValidationResult("Invalid phone number format.");
        }
    }
}
