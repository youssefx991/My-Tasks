using System.ComponentModel.DataAnnotations;

namespace SD46API.Validators
{
    public class DateInPastAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var date = value as DateTime?;
            if(date > DateTime.Now) { return new ValidationResult(null); }
            return ValidationResult.Success;
        }
        //public override bool IsValid(object? value)
        //{
        //    var date = value as DateTime?;
        //   // if (date is null) return false;
        //    if (date > DateTime.Now) return false;
        //    return true;
        //}
    }
}
